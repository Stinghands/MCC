using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MCC.Models;

namespace MCC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly PaymentContext _context;

        public PaymentsController(PaymentContext context)
        {
            _context = context;
        }
        // GET: api/Payments
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Payment>>> GetPayments()
        //{
        //    return await _context.Payments.ToListAsync();
        //}

        // GET: api/Payments/1
        [HttpGet("{UserId}")]
        public async Task<ActionResult<IEnumerable<Payment>>> GetPayment(int UserId)
        {
            var payment = await _context
                .Payments
                .Select(item => new Payment
                {
                    Id = item.Id,
                    UserId = item.UserId,
                    Date = item.Date,
                    Amount = item.Amount,
                    Status = (item.Status == "Closed" ? "Closed": "Reason - Pending")
                })
                .Where(p => p.UserId == UserId)
                .OrderByDescending(p => p.Date)
                .ToListAsync();

            if (payment == null)
                return NotFound();

            return Ok(payment);
        }
    }
}
