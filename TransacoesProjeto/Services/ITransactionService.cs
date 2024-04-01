using TransacoesProjeto.Models;

namespace TransacoesProjeto.Services
{
    public interface ITransactionService
    {
        Task CreateTransaction(Transaction transaction);
    }
}
