using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace chromium_updater_sharp.classes
{
	class SettingsIo
	{
		internal static readonly string SettingsDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
													  "\\plusperks Projects\\Chromium Updater#";
		internal static readonly string SettingsFile = Path.Combine(SettingsDir, "Settings.xml");
		private static XElement _xmlSettings;

		internal static void SetupSettingsFile()
		{
			if (!Directory.Exists(SettingsDir))
			{
				Directory.CreateDirectory(SettingsDir);
			}
			if (!File.Exists(SettingsFile))
			{
				CreateSettings();
			}

			LoadSettingsToMemory();
		}

		private static void CreateSettings()
		{
			var doc = new XDocument(
				new XElement("Options",
			             new XElement("Mode", "2"),
						 new XElement("Freq", "2"),
						 new XElement("BootStart", string.Empty,
							 new XAttribute("Enabled", false))));

			doc.Save(SettingsFile);
		}

		internal static void LoadSettingsToMemory()
		{
			_xmlSettings = XElement.Load(SettingsFile);
		}

		internal static string ReadSettings(string settingName)
		{
			switch (settingName)
			{
				case "Mode":
				case "Freq":
					return _xmlSettings.Descendants(settingName).Single().Value;
				case "BootStart":
					return _xmlSettings.Descendants(settingName).Single().Attribute("Enabled").Value;
			}
			return null;
		}

		internal static void SaveSettings(string settingName, string newValue)
		{
			XElement ele = _xmlSettings.Descendants("Options").Single();

			switch(settingName)
			{
				case "Mode":
				case "Freq":
					ele.SetElementValue(settingName, newValue);
					break;
				case "BootStart":
					ele.Element(settingName).SetAttributeValue("Enabled", newValue);
					break;
			}
		}

		internal static void FinaliseSaveSettings()
		{
			_xmlSettings.Save(SettingsFile);
			_xmlSettings = null;
			LoadSettingsToMemory();
		}
	}
}