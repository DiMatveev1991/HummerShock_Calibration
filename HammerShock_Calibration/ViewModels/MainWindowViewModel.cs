
using MathCore.WPF.ViewModels;
using HammerShock.Inteface;
using DAL_DbHammer.DAL;
using System.Linq;


namespace HammerShock_Calibration.ViewModels
{
	public class MainWindowViewModel : ViewModel
	{
		private readonly IRepository<CalibHammer> _calibHameerRepository;
		public MainWindowViewModel(IRepository<CalibHammer> calibHameerRepository) 
		{
			_calibHameerRepository = calibHameerRepository;
			var calibhammer = calibHameerRepository.items.Take(1).ToArray();
		}
	}
}

