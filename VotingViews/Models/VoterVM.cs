using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VotingViews.Models
{
    public class VoterVM
    {

    }

    public class Profile
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string FullName => $"{FirstName} {MiddleName} {LastName}";

        public String Email { get; set; }

        public string Address { get; set; }

    }

    public class Dashboard
    {
        public string Name { get; set; }

    }

}
