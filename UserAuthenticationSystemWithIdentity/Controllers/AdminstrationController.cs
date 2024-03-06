using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace UserAuthenticationSystemWithIdentity.Controllers
{
    public class AdminstrationController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AdminstrationController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }
    }
}
