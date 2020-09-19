using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginEditWebsite.Models;
using LoginEditWebsite.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LoginEditWebsite.Controllers
{
    public class PersonController : Controller
    {
        private readonly LoginDBContext _context;

        public PersonController(LoginDBContext context)
        {
            _context = context;
        }

        public IActionResult Person()
        {
            PersonListViewModel model = new PersonListViewModel();
            model._context = _context;

            model.PopulatePerson(1);

            ViewData.Model = model;
            return View();
        }
    }
}
