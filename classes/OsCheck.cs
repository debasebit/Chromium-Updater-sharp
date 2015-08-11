using System;
using System.Windows.Forms;

namespace chromium_updater_sharp.classes
{
	class OsCheck
	{
		internal OsCheck()
		{
			if (Environment.OSVersion.Version.Major <= 4) // Prevent "smart" people from using Program Compatibility options on this program.
			{
				MessageBox.Show("This operating system is not supported.");

				Environment.Exit(1);
			}

			else if (Environment.OSVersion.Version.Major == 5)
			{
				if (Environment.OSVersion.Version.Minor == 1) //Windows XP
				{
					MessageBox.Show("The Windows XP operating system is not currently supported at this time. " +
					                "Please use Windows Vista or Windows 7 for the mean time.\n\nSorry for the" +
					                " inconvenience.");

					Environment.Exit(1);
				}
				else if (Environment.OSVersion.Version.Minor == 2) //Windows Server 2003
				{
					MessageBox.Show("The Windows Server 2003 operating system is not supported.");

					Environment.Exit(1);
				}
			}
		}
	}
}