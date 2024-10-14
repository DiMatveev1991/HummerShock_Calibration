using Microsoft.Extensions.DependencyInjection;

namespace HammerShock_Calibration.ViewModels
{
	static class ViewModelRegistrator
	{
		public static IServiceCollection AddViewModels(this IServiceCollection services) => services
			.AddSingleton<MainWindowViewModel>()
			;
	}
}
