using DAL_DbHammer.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DbHammer.DAL
{
	public class CalibHummer: Entity
	{
		public string SerialNumber { get; set; }
		public virtual Sample Sample { get; set; }
		public virtual ICollection<CalibrationInfo> calibrationInfos { get; set; }
	}
}
