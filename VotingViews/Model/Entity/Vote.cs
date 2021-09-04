using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VotingViews.Model.Entity
{
    public class Vote : BaseEntity
    {
        public Position Position { get; set; }
        public int PositionId { get; set; }

        public Election Election { get; set; }
        public int ElectionId { get; set; }

        public Contestant Contestant { get; set; }
        public int ContestantId { get; set; }

        public Voter Voter { get; set; }
        public int VoterId { get; set; }
    }
}
