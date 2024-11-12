using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DbHammer.DAL;
using HammerShock.Inteface;

namespace HammerShock_Calibration.Services
{
	internal class ServisesMass
	{
		private readonly IRepository<Mass> _mass;

		public ServisesMass (IRepository<Mass> mass)
		{
			_mass =mass;
		}
		public  List<Mass> Masses(IRepository<Mass> mass)
		{
			var masses = mass.items.ToList();
			return masses;
		}
	}
}
