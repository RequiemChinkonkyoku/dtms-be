using Microsoft.AspNetCore.Mvc;
using Services.Interface;

namespace DTMS_API.Controllers
{
    [ApiController]
    [Route("api/transactions")]
    public class TransactionController : Controller
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet("{enrollmentId}")]
        public async Task<IActionResult> GetTransactionByEnrollmentId(string enrollmentId)
        {
            try
            {
                var transactionResponse = await _transactionService.GetTransactionByEnrollmentId(enrollmentId);
                return Ok(transactionResponse);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while fetching the transaction.", details = ex.Message });
            }
        }

    }
}
