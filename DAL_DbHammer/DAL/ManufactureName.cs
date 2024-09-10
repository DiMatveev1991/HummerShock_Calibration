using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DbHummer.DAL
{
	public class ManufactureName
	{
		public Guid Id { get; set; }
		[Required]
		public string Manufacture { get; set; }
		public virtual ICollection <Sample> Samples { get; set; }

	}
}
