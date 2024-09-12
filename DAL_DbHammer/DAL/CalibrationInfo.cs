using DAL_DbHammer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DbHammer.DAL
{
	public class CalibrationInfo: Entity
	{

		public virtual CalibHummer CalibHummer { get; set; }

		DateTime DateTimeCalib { get; set; }

		string path { get; set; }
	}
}
