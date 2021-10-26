using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingViews.DTOs;
using VotingViews.Model.Entity;
using VotingViews.Models;

namespace VotingViews.Domain.IService
{
    public interface IPositionService
    {
        public IEnumerable<Position> GetPositionByElectionId(int electionId);

        public Position GetPositionByName(string name);

        public Position GetPositionById(int id);

        public Position AddPosition(Position model);
        
        public List<Position> GetPositionByElectionCode(Guid code);

        public List<Position> ListOfPositions();

        public void DeletePosition(int id);

        public Position UpdatePosition(UpdatePositionDto model, int id);
    }
}
