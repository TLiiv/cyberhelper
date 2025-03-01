using server.Models;

namespace server.Services
{
    public interface IEmailsService
    {
        Task<List<Email>> GetAllEmails();
        Task<List<Email>> GetRandomEmails();
    }
}
