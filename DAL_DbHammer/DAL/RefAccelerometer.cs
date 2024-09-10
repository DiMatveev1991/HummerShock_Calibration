using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DbHummer.DAL
{
	public class RefAccelerometer
	{
		public Guid Id { get; set; }

		[Required]
		public string Manufacture { get; set; }
		public string SerialNumber { get; set; }
		[Required]
		public string Model { get; set; }
		public double PulseTimeMs { get; set; }
		public double AmplitudeImpuls { get; set; }
		public double Сoefficient { get; set; }
		public string dimension { get; set; }
		public string TypeAcs { get; set; }
	}
}
