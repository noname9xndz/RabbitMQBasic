using System.ComponentModel.DataAnnotations.Schema;

namespace Micro.Banking.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }

        public string AccountType { set; get; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal AccountBalance { set; get; }
    }
}