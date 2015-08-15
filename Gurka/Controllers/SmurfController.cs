using Gurka.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gurka.Controllers
{
    public class SmurfController : Controller
    {
        //
        // GET: /Smurf/

        private IUserRepository _userRepo;

        public SmurfController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public ActionResult Index()
        {
            var person = _userRepo.GetUser(1);
            //var db = new GurkaDbContext();
            //var person = db.Persons.First();
            return View(person);
        }

    }
}
