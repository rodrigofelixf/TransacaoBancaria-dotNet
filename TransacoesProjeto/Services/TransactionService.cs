
using TransacoesProjeto.Data.context;
using TransacoesProjeto.Models;

namespace TransacoesProjeto.Services
{
    public class TransactionService : ITransactionService
    {

        private readonly ApplicationDbContext _applicationDbContext;

        public TransactionService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task CreateTransaction(Transaction transaction)
        {
            _applicationDbContext.Transactions.Add(transaction);
            await _applicationDbContext.SaveChangesAsync();

        }
    }
}
