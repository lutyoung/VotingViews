using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VotingViews.Model.Entity
{
    public class Election : BaseEntity
    {
        public string Name { get; set; }
        public Guid Code { get; set; }
        public string Status { get; set; }

        public IList<Position> Positions = new List<Position>();

        public IEnumerable<Vote> Votes = new List<Vote>();
    }
}
