using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using PartnerPlatesBackend.Data;
using PartnerPlatesBackend.Models;

namespace PartnerPlatesBackend.Controllers
{
    [ApiController]
    [Route("payments")]
    [EnableCors("AllowLocalhost3000")]
    public class PaymentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PaymentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetPayments")]
        public IEnumerable<Payment> Get()
        {
            return _context.Payments.ToList();
        }

        [HttpPost(Name = "NewPayment")]
        public IActionResult Create(Payment payment)
        {
            if (payment == null)
            {
                return BadRequest("Invalid payment data.");
            }

            _context.Payments.Add(payment);
            _context.SaveChanges();

            return CreatedAtAction(nameof(Get), new { id = payment.Id }, payment);
        }
    }
}
