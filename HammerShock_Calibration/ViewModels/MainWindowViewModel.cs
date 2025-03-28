
using System;
using System.Collections.Generic;
using MathCore.WPF.ViewModels;
using HammerShock.Inteface;
using DAL_DbHammer.DAL;
using DAL_DbHammer;
using System.Linq;
using System.Threading;
using HammerShock_Calibration.Services;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DAL_DbHammer.Context;
using GalaSoft.MvvmLight.Command;
using HammerShock_Calibration.Services.Interface;
using HammerShock_Calibration.Views.Windows;
using MathCore.Net.Http.Html;
using MathCore.WPF.Commands;
using Microsoft.Extensions.DependencyInjection;
using RelayCommand = GalaSoft.MvvmLight.CommandWpf.RelayCommand;


namespace HammerShock_Calibration.ViewModels
{
	public class MainWindowViewModel : ViewModel
	{
		private readonly IRepository<CalibHammer> _calibHameer;
		private readonly IRepository<Mass> _mass;
		private readonly IRepository<RefAccelerometer> _refAccs;
		private readonly IRepository<SamplRefAcc> _sample;
		private readonly IRepository<SamplRefAcc> _sampleRefAccs;
		private readonly IRepository<CalibrationInfo> _calibinfo;
		private readonly IRepository<ManufactureName> _manafactureName;
		private string  _Title ="HammerShockCailibration";
		private ICommand _OpenMassWindowClickCommand;

		private ViewModel _CurrentModel;
		public ViewModel CurrentModel
		{
			get => _CurrentModel;
			set => Set(ref _CurrentModel, value);
		}

		private ICommand _ShowViewCommand;

		public ICommand ShowViewCommand => _ShowViewCommand
			??= new LambdaCommand(OnCommandOpenWindowClick, CanCommandOpenWindowClick);

		private bool CanCommandOpenWindowClick() => true;

		private void OnCommandOpenWindowClick()
		{
			
			
			_CurrentModel = new MassViewModel(_mass);

			MassWindow massWindow = new MassWindow
			{
				DataContext = _CurrentModel
			};
			SetCentrPositionAndOpen(massWindow);
			
			
		}
		private void SetCentrPositionAndOpen(Window window)
		{
			window.Owner = Application.Current.MainWindow;
			window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
			window.Show();
		}
		#region Конструктор
		public MainWindowViewModel(IRepository<CalibHammer> calibHameer, 
			                       IRepository<Mass> mass, 
			                       IRepository<RefAccelerometer> refAccs, 
			                       IRepository<SamplRefAcc> sample, 
			                       IRepository<SamplRefAcc> sampleRefAccs, 
			                       IRepository<CalibrationInfo> calibinfo,
			                       IRepository<ManufactureName> manafactureName
			                       ) 
		{
			_calibHameer = calibHameer;
			_mass = mass;
			_refAccs = refAccs;
			_sample = sample;
			_sampleRefAccs = sampleRefAccs;
			_calibinfo= calibinfo;
			_manafactureName = manafactureName;
		}
		#endregion
		public string Title
		{
			get => _Title;
			set => Set(ref _Title, value);
		}


	
	
  

	}
}

