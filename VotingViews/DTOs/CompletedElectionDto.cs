using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingViews.Model.Entity;

namespace VotingViews.DTOs
{
    public class CompletedElectionDto
    {
        public List<Election> CompletedElection { get; set; }
    }
}
