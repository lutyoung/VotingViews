using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingViews.Model.Entity;

namespace VotingViews.DTOs
{
    public class ElectionPositionDto
    {
        public string Name { get; set; }

        public int ElectionId {get; set;}
    }
}
