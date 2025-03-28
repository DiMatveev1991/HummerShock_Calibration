using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace DAL_DbHammer.DAL
{
	public class CalibHammer : Entity
	{
		public string SerialNumbers { get; set; }
		public virtual Sample sample { get; set; }
		public virtual ICollection<CalibrationInfo> calibrationInfos { get; set; }
	}
}
