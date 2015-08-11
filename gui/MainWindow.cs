using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using chromium_updater_sharp.classes;

namespace chromium_updater_sharp.gui
{
	internal partial class MainWindow : Form
	{
		#region Declerations
		internal readonly NotifyIcon TrayIcon = new NotifyIcon();
		private readonly ContextMenu _trayMenu = new ContextMenu();

		private readonly List<string> _timeList = new List<string>(6) {"30 mins", "1 hour", "2 hours", "4 hours", "8 hours", "12 hours"};

		internal int CurrentBuild;
		internal string CurrentVersion;
		internal int LatestBuild;

		internal static readonly string ZipFile = Environment.GetEnvironmentVariable("temp") + "\\chromium.zip";
		internal static readonly string LocalUser = Environment.GetEnvironmentVariable("USERPROFILE") + "\\AppData\\Local";
		internal readonly string InstallDir = Environment.GetEnvironmentVariable("USERPROFILE") +
													 "\\AppData\\Local\\Chromium\\Application";
		#endregion

		[STAThread]
		static void Main()
		{
			//Checks if OS is Vista or above
			new OsCheck();

			//Links external references to embedded libraries, useful for portability
			new LinkEmbeddedLibs();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainWindow());
		}

		internal MainWindow()
		{
			InitializeComponent();

			SettingsIo.SetupSettingsFile();

			//Binds time list array to combobox to automatically select the first index 
			//item upon initialisation
			TimeFreq.DataSource = _timeList;

			//Update GUI with saved values from settings file
			switch (SettingsIo.ReadSettings("Mode"))
			{
				case "0":
					CheckRadio.Checked = true;
					break;
				case "1":
					NotifyRadio.Checked = true;
					break;
				case "2":
					UpdateRadio.Checked = true;
					break;
			}

			TimeFreq.SelectedIndex = Convert.ToInt16(SettingsIo.ReadSettings("Freq"));
			StartBootCheck.Checked = Convert.ToBoolean(SettingsIo.ReadSettings("BootStart"));

			//Minimises window to system tray
			_trayMenu.MenuItems.Add("Options", ShowWindow);
			_trayMenu.MenuItems.Add("Force Update (Restarts Timer)", ForceUpdate);
			_trayMenu.MenuItems.Add("-");
			_trayMenu.MenuItems.Add("About", AboutWindow);
			_trayMenu.MenuItems.Add("-");
			_trayMenu.MenuItems.Add("Exit", OnExit);
			TrayIcon.Text = "Chromium Updater#";
			TrayIcon.Icon = Properties.Resources.chromium;
			TrayIcon.ContextMenu = _trayMenu;
			TrayIcon.Visible = true;

			ProgramMode();
			new TimerLoop(this);
		}

		internal void ProgramMode()
		{
			new GetLibVersion(this);
			LocalBuildNumberLabel.Text = string.Format("{0} ({1})", CurrentVersion, CurrentBuild);
			new CheckBuild(this);
			RemoteBuildNumberLabel.Text = Convert.ToString(LatestBuild);

			switch (Convert.ToInt16(SettingsIo.ReadSettings("Mode")))
			{
				case 1: //'Notify only' option
					if (CurrentBuild < LatestBuild)
					{
						TrayIcon.BalloonTipTitle = "A new Chromium build is available";
						TrayIcon.BalloonTipText = string.Format("Build: {0} -> {1}", CurrentBuild, LatestBuild);
						TrayIcon.BalloonTipIcon = ToolTipIcon.Info;
						TrayIcon.ShowBalloonTip(10000);
						TrayIcon.Text = "Chromium Updater# - Update available";
					}
					break;

				case 2: //'Auto update' option
					if (CurrentBuild < LatestBuild)
					{
						TrayIcon.BalloonTipTitle = "A new Chromium build is available";
						TrayIcon.BalloonTipText = "Updating now\n" + string.Format("Build: {0} -> {1}", CurrentBuild, LatestBuild);
						TrayIcon.BalloonTipIcon = ToolTipIcon.Info;
						TrayIcon.ShowBalloonTip(10000);
						TrayIcon.Text = "Chromium Updater# - Updating...";
						try
						{
							new UpdateBuild(this);
						}
						catch (Exception e)
						{
							MessageBox.Show(e.ToString());
						}
					}
					break;
			}
		}

		private void ButtonClick(object sender, EventArgs e)
		{
			//Use switch cases for buttons for code readability and maintenance purposes
			switch (((Button)sender).Name)
			{
				case "InstallDirButton":
					using (var pr = new Process())
					{
						pr.StartInfo.FileName = @"explorer";
						pr.StartInfo.Arguments = Environment.GetEnvironmentVariable("USERPROFILE") +
						                         "\\AppData\\Local\\Chromium\\Application";
						pr.Start();
					}
					break;

				case "UserDirButton":
					using (var pr = new Process())
					{
						pr.StartInfo.FileName = @"explorer";
						pr.StartInfo.Arguments = Environment.GetEnvironmentVariable("USERPROFILE") +
												 "\\AppData\\Local\\Chromium\\User Data";
						pr.Start();
					}
					break;

				case "SaveButton":
					if (CheckRadio.Checked)
					{
						SettingsIo.SaveSettings("Mode", Convert.ToString(0));
					}
					else if (NotifyRadio.Checked)
					{
						SettingsIo.SaveSettings("Mode", Convert.ToString(1));
					}
					else if (UpdateRadio.Checked)
					{
						SettingsIo.SaveSettings("Mode", Convert.ToString(2));
					}

					SettingsIo.SaveSettings("Freq", Convert.ToString(TimeFreq.SelectedIndex));

					SettingsIo.SaveSettings("BootStart", Convert.ToString(StartBootCheck.Checked));

					SettingsIo.FinaliseSaveSettings();

					TimerLoop.Tmr.Stop();
					TimerLoop.Tmr.Dispose();
					new TimerLoop(this);
					break;

				case "CancelButton":
					//Minimises window to tray
					WindowState = FormWindowState.Minimized;
					ShowInTaskbar = false;
					break;
			}
		}

		private void ShowWindow(object sender, EventArgs e)
		{
			ShowInTaskbar = true;
			WindowState = FormWindowState.Normal;
		}

		private void ForceUpdate(object sender, EventArgs e)
		{
			ProgramMode();
			TimerLoop.Tmr.Stop();
			TimerLoop.Tmr.Dispose();
			new TimerLoop(this);
		}

		private void AboutWindow(object sender, EventArgs e)
		{
			var aw = new AboutWindow();
			aw.ShowDialog(this);
		}

		private void OnExit(object sender, EventArgs e)
		{
			Application.Exit();
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);
			TrayIcon.Visible = false;
		}
	}
}