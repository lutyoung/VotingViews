using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VotingViews.Context;
using VotingViews.Domain.IRepository;
using VotingViews.Model.Entity;

namespace VotingViews.Domain.Repository
{
    public class VoterRepository : IVoterRepository
    {
        private readonly ApplicationContext _context;

        public VoterRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Voter FindByUserId(int userid)
        {
            return _context.Voters.FirstOrDefault(i => i.UserId == userid);
        }

        public Voter AddVoter(Voter voter)
        {
            _context.Voters.Add(voter);
            _context.SaveChanges();
            return voter;
        }

        public List<Voter> GetAll()
        {
            return _context.Voters.ToList();
        }

        public void DeleteVoter(int id)
        {
            var investor = _context.Voters.FirstOrDefault(i => i.UserId.Equals(id));
            _context.Voters.Remove(investor);
            _context.SaveChanges();
        }

        public Voter UpdateVoter(Voter voter)
        {
            _context.Voters.Update(voter);
            _context.SaveChanges();
            return voter;
        }

        public Voter GetVoterDetailsById(int id)
        {
            return _context.Voters
                .Include(i => i.User)
                .FirstOrDefault(i => i.UserId == id);
        }
    }
}

