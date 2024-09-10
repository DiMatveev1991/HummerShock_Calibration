
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammerShock_Calibration.ViewModels
{
		public class MainWindowViewModel: MathCore.WPF.ViewModels.ViewModel
	{
		#region Title
		    private string _Title = "lable";
			public string Title { get => _Title; set => Set(ref _Title, value); }
		}
	     #endregion
}

