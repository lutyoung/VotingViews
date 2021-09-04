using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VotingViews.Model.Entity
{
    public class Contestant
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Position Position { get; set; }
        public int PositionId { get; set; }

        public IEnumerable<Vote> Votes = new List<Vote>();
    }
}
