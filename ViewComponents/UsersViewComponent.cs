using Microsoft.AspNetCore.Mvc;
using razor_pages.Services;
using System.Threading.Tasks;

namespace razor_pages.ViewComponents
{
    public class UsersViewComponent : ViewComponent
    {
        private IUserService _userService;

        public UsersViewComponent(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var users = await _userService.GetUsersAsync();
            return View(users);
        }
    }
}