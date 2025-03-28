using Microsoft.Extensions.DependencyInjection;

namespace HammerShock_Calibration.ViewModels
{
	public class ViewModelLocator
	{
		public MainWindowViewModel MainWindowModel => 
			App.Services.GetRequiredService<MainWindowViewModel>();

		public MassViewModel MassWindowViewModel =>
			App.Services.GetRequiredService<MassViewModel>();
	}
}
