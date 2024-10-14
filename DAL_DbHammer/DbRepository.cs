using DAL_DbHammer.Context;
using DAL_DbHammer.DAL;
using DAL_DbHammer;
using HammerShock.Inteface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL_DbHammer
{
	internal class DbRepository<T> : IRepository<T> where T : Entity, new()
	{
		private readonly HummerShockDb _db;
		private readonly DbSet<T> _dbSet;
		public bool AutoSaveChanges { get; set; } = true;
		public DbRepository(HummerShockDb db) 
		{
		_db= db;
		_dbSet= db.Set<T>();
		}
		
		public virtual IQueryable<T> items => _dbSet;

		public T Add(T item)
		{
			if (item==null) throw new ArgumentNullException(nameof(item));
			_db.Entry(item).State = EntityState.Added;
			if (AutoSaveChanges)
			_db.SaveChanges();
			return item;
		}

		public async Task<T> AddAsync(T item, CancellationToken Cancel = default)
		{
			if (item == null) throw new ArgumentNullException(nameof(item));
			_db.Entry(item).State = EntityState.Added;
			if (AutoSaveChanges)
				await _db.SaveChangesAsync(Cancel).ConfigureAwait(false);
			return item;
		}

		public async Task RemoveAsync (Guid id, CancellationToken Cancel = default)
		{
			_db.Remove(new T { Id = id });
			if (AutoSaveChanges)
			await _db.SaveChangesAsync(Cancel).ConfigureAwait(false);
		}

		public T Get(Guid id) => items.SingleOrDefault (item => item.Id == id);
		public async Task<T> GetAsync(Guid id, CancellationToken Cancel = default) =>await items
		.SingleOrDefaultAsync (item => item.Id == id, Cancel)
		.ConfigureAwait(false);

		public void Remove(Guid id)
		{
			//var item = Get(id);
			//if (item is null) return;
			//_db.Entry(item);		

			_db.Remove(new T { Id = id });
			if (AutoSaveChanges)
			_db.SaveChanges();
		}

		public void Update(T item)
		{
			if (item == null) throw new ArgumentNullException(nameof(item));
			_db.Entry(item).State = EntityState.Modified;
			if (AutoSaveChanges)
			_db.SaveChanges();
		}

		public async Task UpdateAsync(T item, CancellationToken Cancel = default)
		{
			if (item == null) throw new ArgumentNullException(nameof(item));
			_db.Entry(item).State = EntityState.Modified;
			if (AutoSaveChanges)
			await _db.SaveChangesAsync(Cancel).ConfigureAwait(false);
		}
	}
	class SampleRepository: DbRepository<Sample>
	{
		public SampleRepository (HummerShockDb db): base(db){ }
	}
}
