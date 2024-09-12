using DAL_DbHammer.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DbHammer.DAL
{
	public class Mass: Entity
	{
		[Required]
		public string Name { get; set; }
		public double mass { get; set; }
		public string dimension { get; set; }
	}
}
