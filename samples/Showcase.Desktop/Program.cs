using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Perspex;

namespace Showcase.Desktop
{
	static class Program
	{
		static void Main(string[] args)
		{
			var app = new App();

			if (args.Contains("--gtk"))
			{
				app.UseGtkSubsystem();
				app.UseCairo();
			}
			else
			{
				app.UseWin32Subsystem();
				if (args.Contains("--skia"))
				{
					app.UseSkia();
				}
				else
				{
					app.UseDirect2D();
				}
			}

			app.Run();
		}
	}
}
