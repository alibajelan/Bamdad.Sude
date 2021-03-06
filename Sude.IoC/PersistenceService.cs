﻿using Microsoft.Extensions.DependencyInjection.Extensions;
using Sude.Domain.Interfaces;
using Sude.Persistence.Repository;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class PersistenceService
    {
        public static IServiceCollection AddPersistenceService(this IServiceCollection services)
        {
            services.TryAddEnumerable(new ServiceDescriptor[]
            {
                ServiceDescriptor.Scoped<IUserRepository, UserRepository>(),
                ServiceDescriptor.Scoped<IServingRepository, ServingRepository>()
            });

            return services;
        }
    }
}
