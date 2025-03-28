using System.ComponentModel.DataAnnotations;

namespace DAL_DbHammer.DAL
{
	public class Mass : Entity
	{
		[Required]
		public string Name { get; set; }
		public double mass { get; set; }
		public string dimension { get; set; }
	}
}
