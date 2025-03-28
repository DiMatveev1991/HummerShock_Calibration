using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HammerShock_Calibration.Services.Interface;
using HammerShock.Inteface;
using DAL_DbHammer.DAL;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
using System.Windows;


namespace HammerShock_Calibration.Services
{
	public class ServicesSaveLoadJson <T> : IServicesSaveLoadJson <T> where T : class, IEntity, new ()
	{
		JsonSerializerOptions options = new JsonSerializerOptions()
		{
			ReferenceHandler = ReferenceHandler.Preserve,
			WriteIndented = true
		};
		public async Task SaveJsonAsync(T item, string FilePath) 
		{
			if (!File.Exists(FilePath))
			{
				using (FileStream sw = File.Create(FilePath))
				{
					await JsonSerializer.SerializeAsync(sw, item, options);
				}
			}
			else
			{
				File.Delete(FilePath);
				using (FileStream sw = File.Create(FilePath))
				{
					await JsonSerializer.SerializeAsync(sw, item, options);
				}

			}
		}

		public async Task<T> LoadJsonAsync (string filePath)
			{

				using (FileStream sw = File.OpenRead(filePath))
					return await  JsonSerializer.DeserializeAsync<T>(sw, options);
			}


	}
}

