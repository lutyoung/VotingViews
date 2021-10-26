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
    public class VoterService : IVoterService
    {
        private readonly IVoterRepository _voter;

        public VoterService(IVoterRepository voter)
        {
            _voter = voter;
        }

        public Voter Update(Voter voter) => _voter.Update(voter);

        public List<Voter> GetAll() => _voter.GetAll();

        public Voter AddVoter(Voter voter) => _voter.AddVoter(voter);

        public bool  Exists(int id) => _voter.Exists(id);

        public Voter GetVoterByUserId(int userId) => _voter.FindByUserId(userId);

        public Voter FindById(int id) => _voter.FindbyId(id);

        public Voter FindByEmail(string email) => _voter.FindByEmail(email);

        public void DeleteVoter(int id)
        {
            _voter.DeleteVoter(id);
        }

    }
}
