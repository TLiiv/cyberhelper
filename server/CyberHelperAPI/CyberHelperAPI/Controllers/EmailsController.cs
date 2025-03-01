using CyberHelperAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CyberHelperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/emails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Email>>> GetAllEmails()
        {
            var emails = await _context.Emails.ToListAsync();
            return Ok(emails);
        }
    }
}
