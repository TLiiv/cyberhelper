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

            for (int i = 1; i <= 8; i++)
            {
                if (groupedByDifficulty.TryGetValue(i, out var group))
                {
                    var random = new Random();
                    var selected = group[random.Next(group.Count)];
                    result.Add(selected);
                }
            }

            return result;
        }
    }
}
