using Microsoft.AspNetCore.Mvc;
using razor_pages.Services;
using System.Threading.Tasks;

namespace razor_pages.ViewComponents
{
    public class UserViewComponent : ViewComponent
    {
        private IUserService _userService;

        public UserViewComponent(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var user = await _userService.GetUserAsync(id);
            return View(user);
        }
    }
}