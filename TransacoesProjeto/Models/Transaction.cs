using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TransacoesProjeto.Models
{

    [Table("TRANSACTIONS")]
    public class Transaction
    {
        [Key]
        public long Id { get; set; }
        public long Payer { get; set; }
        public long Payee { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Value { get; set; }
        public DateTime CreateAt { get; set; }

        public Transaction() { }

        public Transaction(long id, long payer, long payee, decimal value, DateTime createAt)
        {
            Id = id;
            Payer = payer;
            Payee = payee;
            Value = Math.Round(value, 2);
            CreateAt = createAt;
        }
    }
}
