using MediatR;
using Micro.Banking.Application.Interfaces;
using Micro.Banking.Application.Services;
using Micro.Banking.Data.Context;
using Micro.Banking.Data.Repository;
using Micro.Banking.Domain.CommandHandlers;
using Micro.Banking.Domain.Commands;
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

            //Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            // Service
            services.AddTransient<IAccountService, AccountService>();

            // Repository
            services.AddTransient<IAccountRepository, AccountRepository>();

            //Context
            services.AddTransient<BankingDbContext>();
        }
    }
}