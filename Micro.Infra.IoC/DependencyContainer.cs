using System;
using System.Collections.Generic;
using System.Text;
using Micro.Banking.Application.Interfaces;
using Micro.Banking.Application.Services;
using Micro.Banking.Data.Context;
using Micro.Banking.Data.Repository;
using Micro.Banking.Domain.Interfaces;
using Micro.Domain.Core.Bus;
using Micro.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace Micro.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            // Repository
            services.AddTransient<IAccountRepository, AccountRepository>();

            // Service
            services.AddTransient<IAccountService, AccountService>();

            //Context
            services.AddTransient<BankingDbContext>();
        }
    }
}
