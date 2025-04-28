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

            var groupedByDifficulty = emails
                .GroupBy(e => e.Difficulty)
                .ToDictionary(g => g.Key, g => g.ToList());

            var result = new List<Email>();
            var random = new Random();

            for (int level = 1; level <= 8; level++)
            {
                if (groupedByDifficulty.ContainsKey(level))
                {
                    var group = groupedByDifficulty[level];
                    var randomIndex = random.Next(group.Count);
                    var selectedEmail = group[randomIndex];
                    result.Add(selectedEmail);
                }
            }

            return result;
        }
    }
}
