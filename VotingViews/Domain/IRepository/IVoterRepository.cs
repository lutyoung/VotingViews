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
        public Voter FindbyId(int id);

        public Voter FindByEmail(string email);

        public Voter FindByUserId(int userid);

        public Voter AddVoter(Voter voter);

        public List<Voter> GetAll();

        public void DeleteVoter(int id);

        public bool Exists(int id);

        public Voter Update(Voter voter);
    }
}
