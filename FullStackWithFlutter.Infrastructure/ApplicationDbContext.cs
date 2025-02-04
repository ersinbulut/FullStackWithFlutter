﻿using FullStackWithFlutter.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackWithFlutter.Infrastructure
{
	public class ApplicationDbContext:DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base() 
		{

		}

		public DbSet<AppUser> AppUsers { get; set; }
	}
}
