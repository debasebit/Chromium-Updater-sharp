using System;
using System.Timers;
using chromium_updater_sharp.gui;

namespace chromium_updater_sharp.classes
{
	internal class TimerLoop
	{
		private readonly MainWindow _mw;
		internal static int Time;
		internal static Timer Tmr = new Timer();

		internal TimerLoop(MainWindow mainWindow)
		{
			_mw = mainWindow;
			switch (Convert.ToInt16(SettingsIo.ReadSettings("Freq")))
			{
				case 0:
					Time = 30 * 60 * 1000; //30 mins
					break;
				case 1:
					Time = 60 * 60 * 1000; //1 hour
					break;
				case 2:
					Time = 120 * 60 * 1000; //2 hours
					break;
				case 3:
					Time = 240 * 60 * 1000; //4 hours
					break;
				case 4:
					Time = 480 * 60 * 1000; //8 hours
					break;
				case 5:
					Time = 720 * 60 * 1000; //12 hours
					break;
			}

			Tmr.AutoReset = true;
			Tmr.Interval = Time;
			Tmr.Elapsed += Elapsed;
			Tmr.Start();
			GC.KeepAlive(Tmr);
		}

		void Elapsed(object sender, ElapsedEventArgs e)
		{
			_mw.ProgramMode();
		}
	}
}