using Microsoft.AspNetCore.Mvc;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class OpenUsersController : Controller
    {
        private readonly OpenUsersRepository openUsersRepository;

        public OpenUsersController(OpenUsersRepository openUsersRepository)
        {
            this.openUsersRepository = openUsersRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
