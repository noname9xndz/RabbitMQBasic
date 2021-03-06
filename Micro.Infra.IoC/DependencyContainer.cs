﻿using MediatR;
using Micro.Banking.Application.Interfaces;
using Micro.Banking.Application.Services;
using Micro.Banking.Data.Context;
using Micro.Banking.Data.Repository;
using Micro.Banking.Domain.CommandHandlers;
using Micro.Banking.Domain.Commands;
using Micro.Banking.Domain.Interfaces;
using Micro.Domain.Core.Bus;
using Micro.Infra.Bus;
using Micro.Transfer.Application.Interfaces;
using Micro.Transfer.Application.Services;
using Micro.Transfer.Data.Context;
using Micro.Transfer.Data.Repository;
using Micro.Transfer.Domain.EventHandlers;
using Micro.Transfer.Domain.Events;
using Micro.Transfer.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Micro.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

            //Subscriptions
            services.AddTransient<TransferEventHandler>();

            //Domain Event
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();

            //Domain Banking Commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();
            //  services.AddTransient<IRequestHandler<GetAllTransferByStatusCommand, TransferListViewModel>, GetAllByStatusTransferCommandHandler>();

            // Service
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferAccountService, TransferAccountService>();
            // services.AddTransient<IJobService, JobService>();

            // Repository
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ITransferAccountRepository, TransferAccountRepository>();

            //Context
            services.AddTransient<BankingDbContext>();
            services.AddTransient<TransferDbContext>();
        }
    }
}