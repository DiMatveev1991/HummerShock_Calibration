using DAL_DbHammer.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DbHammer.DAL
{
	public class ManufactureName: Entity
	{
		[Required]
		public string Manufacture { get; set; }
		public virtual ICollection <Sample> Samples { get; set; }

	}
}
