using System;
using System.Reflection;

namespace chromium_updater_sharp.classes
{
	/*
		Instructions for embedding files/libraries to executable:
		1. Add file(s) to project
		2. Set files to not copy to build directory
		3. Set build action to 'Content'
		4. Add file to resources.resx under 'Files' category
		5. Initiate class before 'Application.Run'
	*/
	
	class LinkEmbeddedLibs
	{
		internal LinkEmbeddedLibs()
		{
			AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
			{
				var resourceName = new AssemblyName(args.Name).Name + ".dll";
				var resource = Array.Find(
					GetType().Assembly.GetManifestResourceNames(),
					element => element.EndsWith(resourceName));

				using (var stream = Assembly.GetExecutingAssembly()
						.GetManifestResourceStream(resource))
				{
					var assemblyData = new Byte[stream.Length];
					stream.Read(assemblyData, 0, assemblyData.Length);
					return Assembly.Load(assemblyData);
				}
			};
		}
	}
}