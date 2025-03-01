using CyberHelperAPI.Data.Migrations;
using CyberHelperAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CyberHelperAPI.Services
{
    public class EmailsService : IEmailsService
    {
        private readonly ApplicationDbContext _context;
        public EmailsService(ApplicationDbContext context)
        { _context = context; }

        public async Task<List<Email>>GetAllEmails()
        {
            return  await _context.Emails.ToListAsync();       
        }
    }
}
