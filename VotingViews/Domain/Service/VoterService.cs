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

        public Voter AddVoter(Voter voter)
        {
            return _voter.AddVoter(voter);
        }

        public Voter GetVoter(int userId)
        {
            return _voter.FindByUserId(userId);
        }

        public Voter GetVoterFullDetailsById(int voterId)
        {
            return _voter.GetVoterDetailsById(voterId);
        }

        public Voter UpdateVoter(UpdateVoterDto updateVoterDto, int userId)
        {
            var voter = _voter.FindByUserId(userId);
            voter.FirstName = updateVoterDto.FirstName;
            voter.LastName = updateVoterDto.LastName;
            voter.MiddleName = updateVoterDto.MiddleName;
            voter.Address = updateVoterDto.Address;

            _voter.UpdateVoter(voter);
            return voter;
        }
    }
}
