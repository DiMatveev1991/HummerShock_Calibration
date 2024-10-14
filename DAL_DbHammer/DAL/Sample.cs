using System.ComponentModel.DataAnnotations;

namespace DAL_DbHammer.DAL
{
	public class Sample : Entity
	{

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
