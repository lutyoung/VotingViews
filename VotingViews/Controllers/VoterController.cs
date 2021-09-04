using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using VotingViews.Domain.IService;
using VotingViews.DTOs;
using VotingViews.Models;

namespace VotingViews.Controllers
{
    public class VoterController : Controller
    {
        private readonly IVoterService _service;

        public VoterController(IVoterService service)
        {
            _service = service;
        }



        public IActionResult DashBoard(int userId)
        {
            //int userId =int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value ?? string.Empty);

            var voter = _service.GetVoterFullDetailsById(userId);

            var model = new Dashboard
            {
            };
            return View(model);
        }

        public IActionResult Profile(int userId)
        {
            //int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty);

            var voter = _service.GetVoterFullDetailsById(userId);
            var model = new Profile
            {
                FirstName = voter.FirstName,
                LastName = voter.LastName,
                MiddleName = voter.MiddleName,
                Email = voter.Email,
                Address = voter.Address
            };
            return View(model);
        }


        [HttpGet]
        public IActionResult Update(int userId)
        {
            //int userId = Int16.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty);

            var voter = _service.GetVoterFullDetailsById(userId);
            var model = new Profile
            {
                FirstName = voter.FirstName,
                LastName = voter.LastName,
                MiddleName = voter.MiddleName,
                Email = voter.Email,
                Address = voter.Address
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Profile model)
        {
            int userId = Int16.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty);

            UpdateVoterDto updateVoterDto = new UpdateVoterDto
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                MiddleName = model.MiddleName,
                Address = model.Address
            };

            _service.UpdateVoter(updateVoterDto, userId);

            return RedirectToAction(nameof(Profile));
        }

        [HttpPost]
        public IActionResult UpdatePassword()
        {
            return RedirectToAction(nameof(Update));
        }
    }
}
