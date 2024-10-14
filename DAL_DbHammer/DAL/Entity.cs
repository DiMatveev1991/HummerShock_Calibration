
using HammerShock.Inteface;
using System;
namespace DAL_DbHammer.DAL
{
	public abstract class Entity : IEntity
	{
		public Guid Id { get; set; }
	}
}
