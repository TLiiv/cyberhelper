using CyberHelperAPI.Models;

namespace CyberHelperAPI.Services
{
    public interface IEmailsService
    {
        Task<List<Email>> GetAllEmails();
    }
}
