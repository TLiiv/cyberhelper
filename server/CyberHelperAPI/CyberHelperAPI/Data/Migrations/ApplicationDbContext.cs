using CyberHelperAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CyberHelperAPI.Data.Migrations
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }

        public DbSet<Email> Emails { get; set; }
        public DbSet<EmailAnswer> EmailAnswers { get; set; }
        public DbSet<TestResult> TestResults { get; set; }
    }
}
