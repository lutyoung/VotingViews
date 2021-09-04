using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VotingViews.Model.Entity;

namespace VotingViews.Domain.IRepository
{
    public interface IVoterRepository
    {
        public Voter FindByUserId(int userId);

        public Voter AddVoter(Voter voter);

        public List<Voter> GetAll();

        public void DeleteVoter(int id);

        public Voter UpdateVoter(Voter voter);

        public Voter GetVoterDetailsById(int id);
    }
}
