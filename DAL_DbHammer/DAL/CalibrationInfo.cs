using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DbHummer.DAL
{
	public class CalibrationInfo
	{
		public Guid Id { get; set; }

		public virtual CalibHummer CalibHummer { get; set; }

		DateTime DateTimeCalib { get; set; }

		string path { get; set; }
	}
}
