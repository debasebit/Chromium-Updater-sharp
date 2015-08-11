using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace chromium_updater_sharp.gui
{
	internal partial class AboutWindow : Form
	{
		internal AboutWindow()
		{
			InitializeComponent();
		}

		private void AboutWindowLoad(object sender, EventArgs e)
		{
			var ico = new Icon(Properties.Resources.chromium, 128, 128);
			AppIcon.Image = ico.ToBitmap();
		}

		private void LinkLabelLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(Directory.GetCurrentDirectory() + "\\License.txt");
		}
	}
}