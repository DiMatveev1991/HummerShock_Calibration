using System.Collections.Generic;

namespace DAL_DbHammer.DAL
{
	public class CalibHummer : Entity
	{
		public string SerialNumber { get; set; }
		public virtual Sample Sample { get; set; }
		public virtual ICollection<CalibrationInfo> calibrationInfos { get; set; }
	}
}
