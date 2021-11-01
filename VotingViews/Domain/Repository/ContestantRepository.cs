﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using VotingViews.Context;
using VotingViews.Domain.IRepository;
using VotingViews.Model.Entity;

namespace VotingViews.Domain.Repository
{
    public class ContestantRepository : IContestantRepository
    {
        private readonly ApplicationContext _context;

        public ContestantRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Contestant AddContestant(Contestant contestant)
        {
            _context.Contestants.Add(contestant);
            _context.SaveChanges();
            return contestant;
        }

        public void DeleteContestant(int id)
        {
            Contestant contestant = _context.Contestants.Find(id);
            if (contestant == null) return;
            _context.Contestants.Remove(contestant);
            _context.SaveChanges();
        }

        public List<Contestant> GetContestantByPositionName(int id)
        {
            var contestant = _context.Contestants.Include(c => c.Position)
                .Where(c => c.Position.Id ==  id).ToList();
            return contestant;
        }

        public async Task VoteContestant(int id, string email)
        {
            var voter = await _context.Voters.FirstOrDefaultAsync(c => c.Email == email);
            var contestant = await _context.Contestants.FirstOrDefaultAsync(c => c.Id == id);
            if (contestant == null || voter == null)
            {
                return;
            }
            else if (voter.VotedContestants.Contains(contestant))
            {
                return;
            }
            else
            {
                contestant.ConestantVote++;
                voter.VotedContestants.Add(contestant);
            }

            _context.Contestants.Update(contestant);
            await _context.SaveChangesAsync();
        }

        public Contestant FindContestantById(int id)
        {
            return _context.Contestants.SingleOrDefault(a=>a.Id == id);
        }

        public async Task<List<Contestant>> GetAll()
        {
            var contestant = await _context.Contestants.ToListAsync();
            return contestant;
        }

        public Contestant UpdateContestant(Contestant model)
        {
            _context.Contestants.Update(model);
            _context.SaveChanges();
            return model;
        }
    }
}
