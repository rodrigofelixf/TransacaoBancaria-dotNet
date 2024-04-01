using Microsoft.AspNetCore.Mvc;
using TransacoesProjeto.Models;
using TransacoesProjeto.Services;

namespace TransacoesProjeto.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {

        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost]
        public async Task<ActionResult<Transaction>> CreateTransaction(Transaction transaction)
        {
            await _transactionService.CreateTransaction(transaction);
            return CreatedAtAction(nameof(CreateTransaction), transaction);

        }
    }
}
