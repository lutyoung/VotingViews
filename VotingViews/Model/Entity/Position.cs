using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VotingViews.Model.Entity
{
    public class Position :BaseEntity    
    {
        public string Name { get; set; }
        public Election Election { get; set; }
        public int ElectionId { get; set; }

        public IList<Contestant> Contestants = new List<Contestant>();

        public IEnumerable<Vote> Votes = new List<Vote>();
    }
}
