using DAL_DbHammer.DAL;
using HammerShock.Inteface;
using Microsoft.Extensions.DependencyInjection;

namespace DAL_DbHammer
{
	public static class RepositoryRegistrator
	{
		public static IServiceCollection AddRepositoriesInDb(this IServiceCollection services) => services
		.AddTransient<IRepository<Mass>, DbRepository<Mass>>()
		.AddTransient<IRepository<RefAccelerometer>, RefAccelerometerRepository>()
		.AddTransient<IRepository<ManufactureName>, ManufactureNameRepository>()
		.AddTransient<IRepository<Sample>, SampleRepository>()
		.AddTransient<IRepository<CalibHammer>, CalibHummerRepository>()
		.AddTransient<IRepository<CalibrationInfo>, CalibrationInfoRepository>()
		.AddTransient<IRepository<SamplRefAcc>, SamplRefAccRepository>()
		;
	}
}
