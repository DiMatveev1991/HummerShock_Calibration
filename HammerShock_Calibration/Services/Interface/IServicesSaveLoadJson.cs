using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_DbHammer.DAL;
using HammerShock.Inteface;

namespace HammerShock_Calibration.Services.Interface
{
	public interface IServicesSaveLoadJson <T>  where T : class, IEntity, new ()
	{
		Task SaveJsonAsync(T item, string filePath);
		Task<T> LoadJsonAsync(string filePath);
	}
}

