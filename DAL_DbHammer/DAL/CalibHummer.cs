using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DbHummer.DAL
{
	public class CalibHummer
	{
		public Guid Id { get; set; }
		public string SerialNumber { get; set; }
		public virtual Sample Sample { get; set; }
		public virtual ICollection<CalibrationInfo> calibrationInfos { get; set; }
	}
}
