using server.Data.Migrations;
using server.Models;
using Microsoft.EntityFrameworkCore;

namespace server.Services
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

        public async Task<List<Email>> GetRandomEmails()
        {
           var emails = await _context.Emails.ToListAsync();
           var randomEmails = emails.OrderBy(x => Guid.NewGuid()).Take(10).ToList();
           
           return randomEmails;
        }
    }
}
