using HammerShock_Calibration.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using HammerShock_Calibration.Services.Interface;
using DAL_DbHammer.DAL;
using HammerShock.Inteface;

namespace HammerShock_Calibration.Services
{
	static class ServicesRegistrator
	{
		public static IServiceCollection AddServices(this IServiceCollection services) => services
			.AddSingleton<MainWindowViewModel>()
			.AddSingleton<MassViewModel>()
		.AddTransient< IServicesSaveLoadJson<CalibHammer>, ServicesSaveLoadJson <CalibHammer>>()
		//.AddTransient<IServicesSaveLoadJson<RefAccelerometer>, ServicesSaveLoadJson<RefAccelerometer>>()
		;
	}
}
