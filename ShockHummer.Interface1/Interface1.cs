﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShockHummer.Interface
{
		public interface IRepository<T> where T : class, new()
		{
			IQueryable<T> Items { get; }
			T Get(int id);
		    Task<T> GetAsync(int id, CancellationToken Cancel = default);
			T Add(T item);
		    Task<T> AddAsync(T item, CancellationToken Cancel = default);
		    T Update(T item);
		    Task UpdateAsync(T item, CancellationToken Cancel = default);
		    void Remove(int id);
		    Task RemoveAsync(int id, CancellationToken Cancel = default);;
		}
	
}
