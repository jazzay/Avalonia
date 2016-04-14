using System;
using System.Linq;
using Perspex;
//using Perspex.Controls;
//using Perspex.Diagnostics;
using Perspex.Markup.Xaml;
using Perspex.Controls;
using Perspex.Media;
//using Perspex.Logging.Serilog;
//using Serilog;

namespace Showcase
{
	public class App : Application
	{
		public App()
		{
			RegisterServices();
		}

		// Move this to be Runtime configurable
		//		public static void AttachDevTools(Window window)
		//		{
		//#if DEBUG
		//			DevTools.Attach(window);
		//#endif
		//		}

		// This should be part of the Wrapping application
		//
		//static void Main(string[] args)
		//{
		//	var app = new App();
		//	var window = new MainWindow();
		//	window.Show();
		//	app.Run(window);
		//}

		private void InitializeComponent()
		{
			PerspexXamlLoader.Load(this);
		}

		// Move this to be Runtime configurable
		private void InitializeLogging()
		{
//#if DEBUG
//			SerilogLogger.Initialize(new LoggerConfiguration()
//				.MinimumLevel.Warning()
//				.WriteTo.Trace(outputTemplate: "{Area}: {Message}")
//				.CreateLogger());
//#endif
		}


		// Passing platform ID is an interim for now until I figure out
		// the best way to config at runtime across all platforms
		public void Run()
		{
			// host application should choose this
			//InitializeSubsystems(platformID);

			InitializeLogging();
			InitializeComponent();

			var window = new MainWindow();
			window.Show();
			this.Run(window);
		}
	}

	public class MainWindow : Window
	{
		public MainWindow()
		{
			this.InitializeComponent();
			//App.AttachDevTools(this);
		}

		private void InitializeComponent()
		{
			//PerspexXamlLoader.Load(this);

			Title = "Showcase";

			Content = new Grid
			{
				Background = Brushes.Green,
				Margin = new Thickness(5),
				Children = new Controls()
				{
					new Button
					{
						Width = 200,
						Height = 50,
						Content = "Hello World",
						[Grid.RowProperty] = 1,
						[Grid.ColumnSpanProperty] = 2,
					}
				}
			};
		}
	}

}
