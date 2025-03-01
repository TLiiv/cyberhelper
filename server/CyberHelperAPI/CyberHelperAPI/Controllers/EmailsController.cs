using CyberHelperAPI.Data.Migrations;
using CyberHelperAPI.Models;
using CyberHelperAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CyberHelperAPI.Controllers
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
        [HttpGet]
        public async Task<ActionResult<List<Email>>> GetAllEmails()
        {
            var data = await _emailsService.GetAllEmails();
            if (data == null || !data.Any())
            {
                return NotFound("No emails found.");
            }
            return Ok(data);
        }
    }
}
