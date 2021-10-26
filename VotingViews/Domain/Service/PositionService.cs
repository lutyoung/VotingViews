using System;
using System.Collections.Generic;
using System.Linq;
using VotingViews.Domain.IRepository;
using VotingViews.Domain.IService;
using VotingViews.DTOs;
using VotingViews.Model.Entity;

namespace VotingViews.Domain.Service
{
    public class PositionService : IPositionService
    {
        private readonly IPositionRepository _position;
        private readonly IElectionRepository _election;

        public PositionService(IPositionRepository position, IElectionRepository election)
        {
            _position = position;
            _election = election;
        }

        public Position AddPosition(Position model)
        {

            var position = _position.AddPosition(model);
            return position;
        }

        public List<Position> GetPositionByElectionCode(Guid code)
        {
            return _position.GetPositionByElectionCode(code);
        }

        public IEnumerable<Position> GetPositionByElectionId(int electionId)
        {
            _election.FindbyId(electionId);
            return _position.GetAll().Where(e => e.ElectionId == electionId);
        }

        public Position GetPositionByName(string name)
        {
            return _position.FindPositionByName(name);
        }

        public Position GetPositionById(int id)
        {
            return _position.FindPositionById(id);
        }

        public List<Position> ListOfPositions()
        {
            return _position.GetAll();
        }

        public void DeletePosition(int id)
        {
            _position.DeletePosition(id);
        }

        public Position UpdatePosition(UpdatePositionDto model, int id)
        {
            var position = _position.FindPositionById(id);

                position.Name = model.Name;
           

            _position.UpdatePosition(position);
            return position;
        }

    }
}
