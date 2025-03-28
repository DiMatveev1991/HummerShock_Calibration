using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HammerShock.Inteface
{
	public interface IEntity
	{
		 Guid Id { get; set; }
	}
	public interface IRepository<T> where T : class, IEntity, new()
	{
		IQueryable<T> items { get; }
		T Get(Guid id);
		Task<T> GetAsync(Guid id, CancellationToken Cancel = default);

		T Add(T items);
		Task <T> AddAsync(T item, CancellationToken Cancel = default);

		void Update (T item);
		Task UpdateAsync(T item, CancellationToken Cancel = default);

		void Remove (Guid id);
		Task RemoveAsync (Guid id, CancellationToken Cancel = default);
	}
}
