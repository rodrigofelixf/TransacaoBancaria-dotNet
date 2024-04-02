using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TransacoesProjeto.Models
{
    [Table("WALLETS")]
    public class Wallet
    {
        [Key]
        public long Id { get; set; }

        public string FullName { get; set; }

        public long Cpf { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int Type { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Balance { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }


        public Wallet()
        {
        }

        public Wallet(long id, string fullName, long cpf, string email, string password, int type, decimal balance, byte[] version)
        {
            Id = id;
            FullName = fullName;
            Cpf = cpf;
            Email = email;
            Password = password;
            Type = type;
            Balance = balance;
            Version = version;
        }


        public Wallet Debit(decimal value)
        {
            return new Wallet(Id, FullName, Cpf, Email, Password, Type, Balance - value, Version);
        }


        public Wallet Credit(decimal value)
        {
            return new Wallet(Id, FullName, Cpf, Email, Password, Type, Balance + value, Version);
        }
    }
}
