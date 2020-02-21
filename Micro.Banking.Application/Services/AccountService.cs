using Micro.Banking.Application.Interfaces;
using Micro.Banking.Application.Models;
using Micro.Banking.Domain.Commands;
using Micro.Banking.Domain.Interfaces;
using Micro.Banking.Domain.Models;
using Micro.Domain.Core.Bus;
using System.Collections.Generic;

namespace Micro.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _eventBus;

        public AccountService(IAccountRepository accountRepository, IEventBus eventBus)
        {
            _accountRepository = accountRepository;
            _eventBus = eventBus;
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return _accountRepository.GetAllAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTranferCommand = new CreateTransferCommand(accountTransfer.FromAccount, accountTransfer.ToAccount,
                accountTransfer.TransferAmount, accountTransfer.PaymentType, accountTransfer.PaymentStatus);
            _eventBus.SendCommand(createTranferCommand);
        }
    }
}