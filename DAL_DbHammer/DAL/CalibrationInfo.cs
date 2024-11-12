using System;

namespace DAL_DbHammer.DAL
{
	public class CalibrationInfo : Entity
	{
		
		public virtual CalibHammer CalibHammer { get; set; }

		public DateTime DateTimeCalib { get; set; }

		public string Path { get; set; }
	}
}
