using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;
using chromium_updater_sharp.gui;

namespace chromium_updater_sharp.classes
{
	class UpdateBuild
	{
		private static MainWindow _mw;
		private readonly Thread _thread;
		private static readonly FastZip Zf = new FastZip();
		private static int _tick;
		private static readonly int Total = (TimerLoop.Time / 1000) / 100 * 50;
		private static Process[] _processName1;
		private static Process[] _processName2;

		internal UpdateBuild(MainWindow mainWindow)
		{
			_thread = new Thread(UpdateBuildMain);
			_mw = mainWindow;
			_thread.Name = "";
			_thread.Start();
		}

		private void UpdateBuildMain()
		{
			string latestUrl =
				String.Format("http://commondatastorage.googleapis.com/chromium-browser-continuous/Win/{0}/chrome-win32.zip",
							  _mw.LatestBuild);
			CheckBuild.Web.DownloadFile(latestUrl, MainWindow.ZipFile);

			_processName1 = Process.GetProcessesByName("chrome"); //Main Chromium process name
			_processName2 = Process.GetProcessesByName("ClickClean"); //Chromium extension that remains running after it's closed - Expand for other extensions if known.

			if (_processName1.Length > 0 || _processName2.Length > 0)
			{
				_mw.TrayIcon.BalloonTipTitle = "Chromium is already running";
				_mw.TrayIcon.BalloonTipText = "Please close Chromium in order for it to update";
				_mw.TrayIcon.BalloonTipIcon = ToolTipIcon.Error;
				_mw.TrayIcon.ShowBalloonTip(15000);
				_mw.TrayIcon.Text = "Chromium Updater# - Ready to update";
			}

			while (_processName1.Length > 0 || _processName2.Length > 0 || _tick < Total)
			{
				Array.Clear(_processName1, 0, _processName1.Length);
				Array.Clear(_processName2, 0, _processName2.Length);
				Thread.Sleep(1000);
				_processName1 = Process.GetProcessesByName("chrome");
				_processName2 = Process.GetProcessesByName("ClickClean");
				_tick++;
			}

			if (_processName1.Length > 0 || _processName2.Length > 0 || _tick == Total) return;

			Zf.ExtractZip(MainWindow.ZipFile, MainWindow.LocalUser + "\\Chromium", "*");

			if (!Directory.Exists(MainWindow.LocalUser + "\\Chromium\\Application"))
			{
				Directory.Move(MainWindow.LocalUser + "\\Chromium\\chrome-win32", MainWindow.LocalUser + "\\Chromium\\Application");
			}
			else
			{
				Directory.Delete(MainWindow.LocalUser + "\\Chromium\\Application", true);
				Directory.Move(MainWindow.LocalUser + "\\Chromium\\chrome-win32", MainWindow.LocalUser + "\\Chromium\\Application");
			}
		}
	}
}