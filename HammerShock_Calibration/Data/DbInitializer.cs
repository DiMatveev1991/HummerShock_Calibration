using DAL_DbHammer.Context;
using DAL_DbHammer.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace HammerShock_Calibration.Data
{
	internal class DbInitializer
	{
		private readonly HummerShockDb _db;
		private readonly ILogger<DbInitializer> _logger;
		public DbInitializer(HummerShockDb db, ILogger<DbInitializer> Loger)
		{
			_db = db;
			_logger = Loger;
		}
		public async Task InitializeAsync()
		{
			await _db.Database.EnsureDeletedAsync().ConfigureAwait(false);
			await _db.Database.MigrateAsync();

			if (await _db.CalibHummers.AnyAsync()) return;
			await InitializeMass();
		}
		public async Task InitializeMass()
		{
			Mass M1 = new Mass()
			{
				Name = "M1",
				mass = 1,
				dimension = "kg"
			};
			await _db.AddAsync(M1);
			await _db.SaveChangesAsync();

		}
		private async Task InitializeRefAccelerometer()
		{
			RefAccelerometer[] refAccelerometers = new RefAccelerometer[2];
			refAccelerometers[0] = new RefAccelerometer() { Manufacture = "PCB", Model = "301A12", SerialNumber = "1234", TypeAcs = "ICP"};


	}
		private async Task InitializeSamplRefAcc()
		{

		}

		private async Task InitializeManufactureName()
		{

		}

		private async Task InitializeSample()
		{

		}

		private async Task InitializeCalibHummer()
		{

		}

		private async Task InitializeCalibrationInfo()
		{

		}


	}
}
