using DAL_DbHammer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
		}

	}
}
