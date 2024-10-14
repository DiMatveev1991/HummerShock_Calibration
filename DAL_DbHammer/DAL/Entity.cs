using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HammerShock.Inteface;
namespace DAL_DbHammer.DAL
{
	public abstract class Entity:IEntity
	{
		public Guid Id { get; set;}
	}
}
