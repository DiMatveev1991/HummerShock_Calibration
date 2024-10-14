using DAL_DbHammer.DAL;
using Microsoft.EntityFrameworkCore;

namespace DAL_DbHammer.Context
{
	public class HummerShockDb : DbContext
	{
		public DbSet<CalibHummer> CalibHummers { get; set; }
		public DbSet<CalibrationInfo> CalibInfo { get; set; }
		public DbSet<ManufactureName> ManufactureNames { get; set; }
		public DbSet<Mass> masses { get; set; }
		public DbSet<RefAccelerometer> refAccelerometers { get; set; }
		public DbSet<Sample> samples { get; set; }
		public DbSet<SamplRefAcc> samplRefAccs { get; set; }
		public HummerShockDb(DbContextOptions<HummerShockDb> options) : base(options)
		{

		}
	}
}
