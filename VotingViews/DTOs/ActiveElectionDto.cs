using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingViews.Model.Entity;

namespace VotingViews.DTOs
{
    public class ActiveElectionDto
    {
        public List<Election> ActiveElection { get; set; }
    }
}
