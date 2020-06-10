using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAssignment1.Models;

namespace WebAssignment1.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Home");
        }
        
        [HttpGet]
        public ViewResult AddClub()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddClub(Club club)
        {
            if (ModelState.IsValid)
            {
                ClubRepository.addClub(club);
                return View("ListClubs",ClubRepository.Clubs);
            }
            else
            {
                return View();
            }
        }
        public ViewResult ListClubs()
        {
            return View(ClubRepository.Clubs);
        }
       
       
    
        public ViewResult ClubDetails( string clubName)
        {
            return View(ClubRepository.Clubs.FirstOrDefault(c=>c.ClubName==clubName));
        }


        public ViewResult ManagePlayers()
        {
            return View();
        }
    }
}