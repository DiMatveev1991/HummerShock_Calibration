﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammerShock_Calibration.ViewModels
{
	static class ViewModelRegistrator
	{
		public static IServiceCollection AddViewModels(this IServiceCollection services) => services
			.AddSingleton<MainWindowViewModel> ()
			;
	}
}
