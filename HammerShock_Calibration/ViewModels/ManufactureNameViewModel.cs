using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DbHammer.DAL;
using HammerShock.Inteface;
using MathCore.WPF.ViewModels;

namespace HammerShock_Calibration.ViewModels
{
	internal class ManufactureNameViewModel: ViewModel
	{
		private readonly IRepository<ManufactureName> _manafactureName;

		public ManufactureNameViewModel(IRepository<ManufactureName> manafactureName)
		{
			_manafactureName = manafactureName;
		}

	}
}
