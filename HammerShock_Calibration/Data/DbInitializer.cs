using DAL_DbHammer.Context;
using DAL_DbHammer.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
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
			await InitializeRefAccelerometerAndSampleAcs();
			await InitializeManufactureNameAndSample();
			await InitializeCalibHummerand();
			_db.Dispose();
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
		RefAccelerometer refAccelerometers;
		ManufactureName manufactureName;
		Sample[] samples = new Sample[2];
		SamplRefAcc[] samplRefAccs = new SamplRefAcc[2];
		CalibHammer calibHummer1;
		CalibrationInfo[] calibrationInfo = new CalibrationInfo[1];
		
		private async Task InitializeRefAccelerometerAndSampleAcs()
		{
			//RefAccelerometer[] refAccelerometers = new RefAccelerometer[1];
			refAccelerometers = new RefAccelerometer() { Manufacture = "PCB", Model = "301A12", SerialNumber = "2985", TypeAcs = "ICP" };
			samplRefAccs[0] = new SamplRefAcc() { PulseTimeMs = 3.125, AmplitudeImpuls = 49, Сoefficient = 0.04719, dimension = "mV/g", Accelerometer = refAccelerometers };
			samplRefAccs[1] = new SamplRefAcc() { PulseTimeMs = 3.125, AmplitudeImpuls = 100, Сoefficient = 0.04719, dimension = "mV/g", Accelerometer = refAccelerometers };
			//refAccelerometers[1] = new RefAccelerometer() { Manufacture = "PCB", Model = "350A13", SerialNumber = "63670", TypeAcs = "ICP"};
			//refAccelerometers[2] = new RefAccelerometer() { Manufacture = "PCB", Model = "301M26", SerialNumber = "3119", TypeAcs = "ICP"};
			//refAccelerometers[3] = new RefAccelerometer() { Manufacture = "PCB", Model = "301M26", SerialNumber = "LW205199", TypeAcs = "ICP"};

			await _db.AddAsync(refAccelerometers);
			_db.AddRange(samplRefAccs);
			_db.SaveChanges();
			await _db.SaveChangesAsync();
		}

		private async Task InitializeManufactureNameAndSample()
		{
			manufactureName = new ManufactureName() { Manufacture = "GtLab" };
			samples[0] = new Sample() { linearity = 5, LowLevelMeasurement = 10, HighLevelMeasurement = 5000, model = "4V101", Сoefficient = 0.2, dimension = "mV/N", TypeHammer = "ICP", PermissibleCoefficientDeviation = 20, Manufacture = manufactureName };
			samples[1] = new Sample() { linearity = 5, LowLevelMeasurement = 10, HighLevelMeasurement = 500, model = "4V106", Сoefficient = 4, dimension = "mV/N", TypeHammer = "ICP", PermissibleCoefficientDeviation = 20, Manufacture = manufactureName };
			await _db.AddAsync(manufactureName);
			_db.AddRange(samples);
			_db.SaveChanges();
			await _db.SaveChangesAsync();

		}

				

		private async Task InitializeCalibHummerand()
		{
			string SN = "123";
			calibHummer1 = new CalibHammer() { SerialNumbers= "123", sample = samples [0]};
			calibrationInfo[0] = new CalibrationInfo() { calibHammer = calibHummer1, DateTimeCalib = DateTime.Now, path ="путь к файлу" };
			await _db.AddAsync(calibHummer1);
			_db.Add(calibrationInfo[0]);
			await _db.SaveChangesAsync();


		}

	


			
	}
}


