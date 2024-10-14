using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL_DbHammer.DAL
{
	public class RefAccelerometer : Entity
	{

		[Required]
		public string Manufacture { get; set; }
		public string SerialNumber { get; set; }
		[Required]
		public string Model { get; set; }
		public string TypeAcs { get; set; }

		public virtual ICollection<SamplRefAcc> sampleRefAccsrlerometr { get; set; }


	}
}
