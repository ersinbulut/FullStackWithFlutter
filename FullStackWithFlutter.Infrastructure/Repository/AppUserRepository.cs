using FullStackWithFlutter.Core.Interfaces;
using FullStackWithFlutter.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackWithFlutter.Infrastructure.Repository
{
	public class AppUserRepository:GenericRepository<AppUser>, IAppUserRepository
	{
        public AppUserRepository(ApplicationDbContext context):base(context)
        {
            //context.AppUsers.Add();
        }
    }
}
