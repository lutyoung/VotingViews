using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingViews.DTOs;
using VotingViews.Model.Entity;
using VotingViews.Models;

namespace VotingViews.Domain.IService
{
    public interface IVoterService
    {
        public Voter AddVoter(Voter voter);

        public Voter GetVoter(int userId);

        public Voter GetVoterFullDetailsById(int voterId);

        public Voter UpdateVoter(UpdateVoterDto updateVoterDto, int voterId);
    }
}
