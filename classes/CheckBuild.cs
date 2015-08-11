using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using chromium_updater_sharp.gui;

namespace chromium_updater_sharp.classes
{
	class CheckBuild
	{
		private static MainWindow _mw;
		internal static WebClient Web = new WebClient();

		internal CheckBuild(MainWindow mainWindow)
		{
			_mw = mainWindow;
			try
			{
				_mw.LatestBuild = Convert.ToInt32(
					Web.DownloadString("https://commondatastorage.googleapis.com/chromium-browser-continuous/Win/LAST_CHANGE"));
			}
			catch (WebException)
			{
				var errorMessage = new StringBuilder(175);
				errorMessage.Append("Unable to connect to the Chromium server, possible reasons could be:");
				errorMessage.Append(Environment.NewLine);
				errorMessage.Append(Environment.NewLine);
				errorMessage.Append("\u2022 No active Internet connection");
				errorMessage.Append(Environment.NewLine);
				errorMessage.Append("\u2022 A firewall is blocking access");
				errorMessage.Append(Environment.NewLine);
				errorMessage.Append("\u2022 The server is currently unavailable");

				_mw.TrayIcon.BalloonTipTitle = "Problem accessing server";
				_mw.TrayIcon.BalloonTipText = errorMessage.ToString();
				_mw.TrayIcon.BalloonTipIcon = ToolTipIcon.Error;
				_mw.TrayIcon.ShowBalloonTip(15000);
				_mw.LatestBuild = 0;
			}
		}
	}
}