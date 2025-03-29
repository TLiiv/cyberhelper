using server.Data.Migrations;
using server.Models;
using server.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : ControllerBase
    {
        private readonly IEmailsService _emailsService;

        public EmailsController(IEmailsService emailsService)
        {
            _emailsService = emailsService;
        }

        // GET: api/emails
        [HttpGet("all")]
        public async Task<ActionResult<List<Email>>> GetAllEmails()
        {
            var data = await _emailsService.GetAllEmails();
            if (data == null || !data.Any())
            {
                return NotFound("No emails found.");
            }
            
            return Ok(data);
        }
        [HttpGet("random")]
        public async Task<ActionResult<List<Email>>> GetRandomEmails()
        {
            var data = await _emailsService.GetRandomEmails();
            if (data == null || !data.Any())
            {
                return NotFound("No emails found.");
            }

            return Ok(data);
        }
    }
}
