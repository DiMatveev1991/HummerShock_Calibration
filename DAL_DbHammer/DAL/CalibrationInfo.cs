using System;

namespace DAL_DbHammer.DAL
{
	public class CalibrationInfo : Entity
	{

		public virtual CalibHammer calibHammer { get; set; }

		public DateTime DateTimeCalib { get; set; }

		public string path { get; set; }
	}
}
