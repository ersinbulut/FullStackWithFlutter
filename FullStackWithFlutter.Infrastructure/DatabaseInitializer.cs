using FullStackWithFlutter.Core.Interfaces;
using FullStackWithFlutter.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackWithFlutter.Infrastructure
{
	public class DatabaseInitializer : IDatabaseInitializer
	{
        private readonly ApplicationDbContext _context;

		public DatabaseInitializer(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task SeedSampleData()
		{
			await _context.Database.EnsureCreatedAsync();

			if (!_context.AppUsers.Any())
			{
				var testUser1 = new AppUser
				{
					FullName = "test user 1",
					MobileNumber = "+905289635869",
					CreatedDate = DateTime.Now,
					CreatedBy = "SeedSampleData"
				};
				var testUser2 = new AppUser
				{
					FullName = "test user 2",
					MobileNumber = "+905289635860",
					CreatedDate = DateTime.Now,
					CreatedBy = "SeedSampleData"
				};

				_context.AppUsers.Add(testUser1);
				_context.AppUsers.Add(testUser2);
				await _context.SaveChangesAsync();
			}
		}
	}
}
