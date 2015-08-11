using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using chromium_updater_sharp.gui;

namespace chromium_updater_sharp.classes
{
	static class NativeMethods
	{
		[DllImport("version.dll", SetLastError = true)]
		internal static extern bool GetFileVersionInfo(string sFileName,
			  int handle, int size, byte[] infoBuffer);

		[DllImport("version.dll", SetLastError = true)]
		internal static extern int GetFileVersionInfoSize(string sFileName,
			  out int handle);

		[DllImport("version.dll", SetLastError = true)]
		internal static extern bool VerQueryValue(byte[] pBlock,
			  string pSubBlock, out string pValue, out uint len);

		[DllImport("version.dll", SetLastError = true)]
		unsafe internal static extern bool VerQueryValue(byte[] pBlock,
			  string pSubBlock, out short* pValue, out uint len);
	}

	class GetLibVersion
	{
		private static MainWindow _mw;

		internal GetLibVersion(MainWindow mainWindow)
		{
			_mw = mainWindow;
			try
			{
				if (File.Exists(_mw.InstallDir + @"\chrome.dll"))
				{
					unsafe
					{
						int handle;
						var size =
							NativeMethods.GetFileVersionInfoSize(_mw.InstallDir + @"\chrome.dll", out handle);

						var buffer = new byte[size];

						if (NativeMethods.GetFileVersionInfo(_mw.InstallDir + @"\chrome.dll", handle, size, buffer)) { }

						short* subBlock;
						uint len;
						if (!NativeMethods.VerQueryValue(buffer, @"\VarFileInfo\Translation", out subBlock, out len)){}

						var spb = @"\StringFileInfo\" + subBlock[0].ToString("X4") +
								  subBlock[1].ToString("X4") + @"\LastChange";

						var spv = @"\StringFileInfo\" + subBlock[0].ToString("X4") +
								  subBlock[1].ToString("X4") + @"\ProductVersion";

						string buildInfo;
						if (NativeMethods.VerQueryValue(buffer, spb, out buildInfo, out len))
						{
							_mw.CurrentBuild = Convert.ToInt32(buildInfo);
						}

						string versionInfo;
						if (NativeMethods.VerQueryValue(buffer, spv, out versionInfo, out len))
						{
							_mw.CurrentVersion = versionInfo;
						}
					}
				}
				else
				{
					_mw.CurrentVersion = String.Empty;
					_mw.CurrentBuild = 0;
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(e.ToString());
			}
		}
	}
}