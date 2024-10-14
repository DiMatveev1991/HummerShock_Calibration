using HammerShock_Calibration.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace HammerShock_Calibration.Services
{
	static class ServicesRegistrator
	{
		public static IServiceCollection AddServices(this IServiceCollection services) => services
		.AddSingleton<MainWindowViewModel>()
			;
	}
}
