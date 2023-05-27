using AgricultureUl.Models;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AgricultureUl.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamsService _teamsService;

        public TeamController(ITeamsService teamsService)
        {
            _teamsService = teamsService;
        }

        public IActionResult Index()
        {
            var values = _teamsService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTeam()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult AddTeam(Team team)
        {

            TeamValidator validationRules = new TeamValidator();
            ValidationResult results = validationRules.Validate(team);
            if (results.IsValid)
            {
                _teamsService.TInsert(team);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();


        }
  
        public IActionResult DeleteTeam(int id)
        {
            var values = _teamsService.TGetById(id);
            _teamsService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateTeam(int id)
        {
            var values = _teamsService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateTeam(Team team)
        {
            _teamsService.TUpdate(team);
            return RedirectToAction("Index");
        }

    }
}
