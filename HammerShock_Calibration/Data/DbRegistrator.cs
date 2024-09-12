using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer;
using Microsoft.EntityFrameworkCore;
using DAL_DbHammer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using DAL_DbHammer;

namespace HammerShock_Calibration.Data
{
	static class DbRegistrator
	{
		public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration Configuration) => services
		.AddDbContext<HummerShockDb>(opt =>
		{
			var type = Configuration["Type"];
			switch (type)
			{
				case null: throw new InvalidOperationException("Не определен тип БД");
				default: throw new InvalidOperationException($"Тип подключения к БД {type} не поддерживается");
				
				case "MSSQL":
					opt.UseSqlServer(Configuration.GetConnectionString(type)); 
				break;
					
				case "SQLite":
					opt.UseSqlite(Configuration.GetConnectionString(type));
					break;

			}
		})
			.AddTransient<DbInitializer>()
			.AddRepositoriesInDb()
			;
	}
}
