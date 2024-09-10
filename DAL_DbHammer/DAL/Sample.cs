using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DbHummer.DAL
{
	public class Sample
	{
		public Guid Id { get; set; }

		public virtual ManufactureName Manufacture { get; set; }
		[Required]
		public string model { get; set; }
		public int LowLevelMeasurement { get; set; }
		public int HighLevelMeasurement { get; set; }
		public double Сoefficient { get; set; }
		public string dimension { get; set; }
		public string TypeHammer { get; set; }
		public double PermissibleCoefficientDeviation { get; set; }
		public double linearity { get; set; }

	}
}
