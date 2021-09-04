using System.ComponentModel.DataAnnotations;

namespace VotingViews.DTOs
{
    public class RegisterUserDto
    {
        public string Type { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string Password { get; set; }
    }
}