using HammerShock_Calibration.Data;
using HammerShock_Calibration.Services;
using HammerShock_Calibration.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HammerShock_Calibration
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private static IHost _Host;

		public static IHost Host => _Host ?? ( _Host = Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build());
		public static IServiceProvider Services => _Host.Services;

		internal static void ConfigureServices(HostBuilderContext host, IServiceCollection services) => services
			.AddDatabase(host.Configuration.GetSection("Database"))
			.AddServices()
			.AddViewModels();
		
		protected override async void OnStartup (StartupEventArgs e)
		{
			var host = Host;
			using (var scope = Services.CreateScope())
				scope.ServiceProvider.GetRequiredService<DbInitializer>().InitializeAsync().Wait();
			base.OnStartup (e);
			host.StartAsync();
		}
		protected override async void OnExit(ExitEventArgs e)
		{
			
			var host = Host;
			base.OnExit(e);
			await host?.StopAsync();
		}
	}
}
