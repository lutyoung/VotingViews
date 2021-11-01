using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingViews.Domain.IRepository;
using VotingViews.Domain.IService;
using VotingViews.DTOs;
using VotingViews.Model.Entity;
using VotingViews.Models;

namespace VotingViews.Domain.Service
{
    public class ElectionService : IElectionService
    {
        private readonly IElectionRepository _election;

        public ElectionService(IElectionRepository election)
        {
            _election = election;
        }

        public CreatedElectionDto AddElection(CreateElectionDto election)
        {
            Election newElection = new Election
            {
                Name = election.Name,
                Status = election.Status,
                Code = Guid.NewGuid()
            };
            var model = _election.AddElection(newElection);

            return new CreatedElectionDto
            {
                Id = model.Id
            };
        }

        public ElectionDto GetElectionByCode(Guid code)
        {
            var election = _election.FindByCode(code);
            return new ElectionDto
            {
                Name = election.Name,
                Code = election.Code,
                Status = election.Status,
                Positions = election.Positions.Select(c => new Position()
                {
                    Id = c.Id,
                    Name = c.Name,
                }).ToList()
            };
        }

        public Election GetElectionById(int id)
        {
            return _election.FindbyId(id);
        }

        public void DeleteElection(int id)
        {
            _election.DeleteElection(id);
        }

        public Election UpdateElection(UpdateElectionDto update, int id)
        {
            var election = _election.FindbyId(id);

            election.Name = update.Name;
            election.Status = update.Status;
            election.StartDate = update.StartDate;
            election.EndDate = update.EndDate;

            _election.UpdateElection(election);
            return election;
        }

        public List<Election> GetAllElections()
        {
            return _election.GetAll();
        }

       
    }
}
