using FullStackWithFlutter.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackWithFlutter.Infrastructure.Repository
{
	public class GenericRepository<T>:IGenericRepository<T> where T : class
	{
		protected readonly ApplicationDbContext _context;

		public GenericRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public Task Add(Task entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(T entity)
		{
			 _context.Set<T>().Remove(entity);
		}

		public async Task<T> Get(int id)
		{
			return await _context.Set<T>().FindAsync(id);
		}

		public async Task<IEnumerable<T>> GetAll()
		{
			return await _context.Set<T>().ToListAsync();
		}

		public async void Update(T entity)
		{
			await _context.Set<T>().AddAsync(entity);
		}
	}
}
