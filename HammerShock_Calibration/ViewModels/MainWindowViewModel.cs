
using MathCore.WPF.ViewModels;

namespace HammerShock_Calibration.ViewModels
{
	public class MainWindowViewModel : ViewModel
	{
		#region Title
		private string _Title = "lable";
		public string Title { get => _Title; set => Set(ref _Title, value); }
	}
	#endregion
}

