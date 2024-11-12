using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using DAL_DbHammer.DAL;
using HammerShock.Inteface;
using HammerShock_Calibration.Services;
using MathCore.WPF.Behaviors;
using MathCore.WPF.ViewModels;

namespace HammerShock_Calibration.ViewModels
{
	public class MassViewModel: ViewModel
	{
		private readonly IRepository<Mass> _mass;
		 
		private List<Mass> _Allmass;
		public List<Mass> AllMasses
		{
			get { return _Allmass; }
		}
		private Mass selectedMass;
		public Mass SelectedMass
		{
			get { return selectedMass; }
			set
			{
				selectedMass = value;
				OnPropertyChanged("SelectedMass");
				
			}

		}


		public MassViewModel(IRepository<Mass> mass)
		{
			_mass = mass;
			ServisesMass servisesMass = new ServisesMass(mass);
			List<Mass> allMass = servisesMass.Masses(mass);
			_Allmass= allMass;
		}
	
		


	}
}
