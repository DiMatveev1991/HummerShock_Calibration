using System;

namespace DAL_DbHammer.DAL
{
	public class CalibrationInfo : Entity
	{

		public virtual CalibHummer CalibHummer { get; set; }

		DateTime DateTimeCalib { get; set; }

		string path { get; set; }
	}
}
