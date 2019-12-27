namespace Micro.Banking.Application.Models
{
    public class AccountTransfer
    {
        public int FromAccount { set; get; }

        public int ToAccount { set; get; }

        public decimal TransferAmount { set; get; }
    }
}