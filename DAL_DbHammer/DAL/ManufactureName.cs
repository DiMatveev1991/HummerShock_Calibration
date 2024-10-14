using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL_DbHammer.DAL
{
	public class ManufactureName : Entity
	{
		[Required]
		public string Manufacture { get; set; }
		public virtual ICollection<Sample> Samples { get; set; }
	}
}
