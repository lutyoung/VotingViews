using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingViews.Model.Entity;

namespace VotingViews.Domain.IRepository
{
    public interface IContestantRepository
    {
        public Contestant AddContestant(Contestant contestant);

        public Contestant FindContestantById(int id);

        Task<List<Contestant>> GetAll();

        Task VoteContestant(int id, string email);

        public Contestant UpdateContestant(Contestant model);

        public List<Contestant> GetContestantByPositionName(int id);

        public void DeleteContestant(int id);
    }
}
