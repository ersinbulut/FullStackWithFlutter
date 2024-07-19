using FullStackWithFlutter.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackWithFlutter.Infrastructure.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ApplicationDbContext _context;
		public IAppUserRepository AppUsers { get; }

		public UnitOfWork(ApplicationDbContext context,IAppUserRepository appUserRepository)
		{
			 AppUsers= appUserRepository;
			_context = context;
		}

		public int Complate()
		{
			return _context.SaveChanges();
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				_context.Dispose();
			}
		}
	}
}
