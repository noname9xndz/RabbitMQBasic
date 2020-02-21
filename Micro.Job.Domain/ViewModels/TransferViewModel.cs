using Micro.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Micro.Job.Domain.ViewModels
{
    public class TransferViewModel
    {
        //        public int id { get;  set; }
        //        public int fromAccount { get;  set; }
        //
        //        public int toAccount { get;  set; }
        //
        //        public decimal transferAmount { get;  set; }
        //
        //        public PaymentType? paymentType { get;  set; }
        //        public PaymentStatus? paymentStatus { get;  set; }

        public int Id { get; set; }

        public string FromAccount { set; get; }

        public string ToAccount { set; get; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal TransferAmount { set; get; }

        public PaymentType? PaymentType { set; get; }
        public PaymentStatus? PaymentStatus { set; get; }
    }
}