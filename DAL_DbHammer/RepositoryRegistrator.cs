using DAL_DbHammer.DAL;
using HammerShock.Inteface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DbHammer
{
	public static class RepositoryRegistrator
	{
		public static IServiceCollection AddRepositoriesInDb(this IServiceCollection services) => services
		.AddTransient<IRepository<Mass>, DbRepository<Mass>>()
        .AddTransient<IRepository<RefAccelerometer>, DbRepository<RefAccelerometer>>()
        .AddTransient<IRepository<ManufactureName>, ManufactureNameRepository>()
		.AddTransient<IRepository<Sample>, SampleRepository>()
		.AddTransient<IRepository<CalibHummer>, CalibHummerRepository>()
		.AddTransient<IRepository<CalibrationInfo>, CalibrationInfoRepository>()
		;
	}
}
