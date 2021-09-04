using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingViews.Models;

namespace VotingViews.Controllers
{
    public class ContestantController : Controller
    {
        [HttpGet]
        public IActionResult Index(IList<ContestantVM> model)
        {
            model = new List<ContestantVM>();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateContestant model)
        {
            //var result = new VoterVM
            //{
            //    Email = model.Email
            //};
            return View();
        }

        [HttpPost]
        public IActionResult Update(UpdateContestant model)
        {
            //var result = new VoterVM
            //{
            //    Email = model.Email
            //};
            return View();
        }

        public IActionResult ContestantVote(IList<ContestantVote> vote)
        {
            vote = new List<ContestantVote>();
            return View(vote);
        }
    }
}
