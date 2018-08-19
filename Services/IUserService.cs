using System.Collections.Generic;
using System.Threading.Tasks;

namespace razor_pages.Services
{
    public interface IUserService
    {
        Task<List<User>> GetUsersAsync();
        Task<User> GetUserAsync(int id);
    }
}