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
        public Voter Update(Voter voter);

        public List<Voter> GetAll();

        public Voter AddVoter(Voter voter);

        public bool Exists(int id);

        public Voter GetVoterByUserId(int userId);

        public Voter FindById(int id);

        public Voter FindByEmail(string email);

        public void DeleteVoter(int id);
    }
}
