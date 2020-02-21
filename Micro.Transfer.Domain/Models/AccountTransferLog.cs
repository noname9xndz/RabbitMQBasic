using Micro.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Micro.Transfer.Domain.Models
{
    public class AccountTransferLog
    {
        public int Id { get; set; }

        public string FromAccount { set; get; }

        public string ToAccount { set; get; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal TransferAmount { set; get; }

        public PaymentType? PaymentType { set; get; }
        public PaymentStatus? PaymentStatus { set; get; }
    }
}