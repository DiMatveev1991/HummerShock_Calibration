using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DAL_DbHammer.DAL
{
	public class ManufactureName : Entity
	{
		[Required]
		public string Manufacture { get; set; }
		
		
		public virtual ICollection<Sample> Samples { get; set; }
	}
}
