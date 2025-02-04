﻿using FullStackWithFlutter.Core.Interfaces;
using FullStackWithFlutter.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackWithFlutter.Infrastructure.DIExtensions
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddRepositories(this IServiceCollection services)
		{
			services.AddScoped<IAppUserRepository,AppUserRepository>();
			services.AddScoped<IUnitOfWork,UnitOfWork>();
			services.AddScoped<IDatabaseInitializer,DatabaseInitializer>();
			return services;
		}
	}
}
