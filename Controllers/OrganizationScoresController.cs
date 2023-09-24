using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class OrganizationScoresController : Controller
    {
        private readonly OrganizationScoresRepository organizationScoresRepository;

        public OrganizationScoresController(OrganizationScoresRepository organizationScoresRepository)
        {
            this.organizationScoresRepository = organizationScoresRepository;
        }    
        public IActionResult Index()
        {
            var model = organizationScoresRepository.GetScore();
            return View(model);
        }

        public IActionResult Create(int? id)
        {
            OrganizationScores model = id == null ? new OrganizationScores() : organizationScoresRepository.GetOrganizationScoresById(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(OrganizationScores model)
        {
            if (ModelState.IsValid)
            {
                organizationScoresRepository.SaveScore(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Details (int? id)
        {
            OrganizationScores model = id == null ? new OrganizationScores() : organizationScoresRepository.GetOrganizationScoresById(id);
            return View(model);
        }

        public IActionResult Adminka()
        {
            var model = organizationScoresRepository.GetScore();
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            organizationScoresRepository.Delete(new OrganizationScores() { id =  id });
            return RedirectToAction("Adminka");
        }
    }
}
