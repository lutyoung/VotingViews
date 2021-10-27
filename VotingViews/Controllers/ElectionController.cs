﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingViews.Context;
using VotingViews.Domain.IService;
using VotingViews.DTOs;
using VotingViews.Model.Entity;
using VotingViews.Models;

namespace VotingViews.Controllers
{
    [Authorize(Roles ="admin")]
    public class ElectionController : Controller
    {
        private readonly IElectionService _service;
        private readonly ApplicationContext _context;

        public ElectionController(IElectionService service, ApplicationContext context)
        {
            _service = service;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _service.GetAllElections();
            return View(model);
        }

       

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateElectionVM model)
        {
            CreateElectionDto create = new CreateElectionDto
            {
                Name = model.Name,
                Status = model.Status
            };
            if (ModelState.IsValid)
            {
                _service.AddElection(create);
            }
            return RedirectToAction("Index", "Election");
        }

        [HttpGet]
        public IActionResult Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var update = _service.GetElectionById(id.Value);
            if (update == null)
            {
                return NotFound();
            }
            return View(update);
        }

        [HttpPost]
        public IActionResult Update(int id, UpdateElectionVM model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            UpdateElectionDto update = new UpdateElectionDto
            {
                Name = model.Name,
                Status = model.Status
            };

            if (ModelState.IsValid)
            {
                _service.UpdateElection(update, id);
                return RedirectToAction("Index", "Election");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var election = _service.GetElectionById(id.Value);
            if (election == null)
            {
                return NotFound();
            }

            return View(election);
        }

        public IActionResult Details(int id , Election election)
        {
             _service.GetElectionById(id);
            ElectionVM model = new ElectionVM
            {
                Name = election.Name,
                Status = election.Status,
                Code = election.Code
            };
            return View(model);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = _service.GetElectionById(id.Value);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {

            _service.DeleteElection(id);
            return RedirectToAction("Index", "Election");
        }
    }
}
