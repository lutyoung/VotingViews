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

        public Election GetElectionByCode(Guid code)
        {
            return _election.FindByCode(code);
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

            _election.UpdateElection(election);
            return election;
        }

        public List<Election> GetAllElections()
        {
            return _election.GetAll();
        }

       
    }
}
