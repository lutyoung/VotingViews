using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VotingViews.Models
{
    public class PositionVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CreatePosition
    {
        public string Name { get; set; }
        public int ElectrionId { get; set; }

    }

    public class UpdatePosition
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
