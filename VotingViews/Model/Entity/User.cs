using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VotingViews.Model.Entity
{
    public class User : BaseEntity
    {
        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string HashSalt { get; set; }

        public Admin Admin { get; set; }

        public Voter Voter { get; set; }

        public Role Role { get; set; }

        public int RoleId { get; set; }
    }
}
