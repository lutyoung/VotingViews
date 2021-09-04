using System;
using VotingViews.Model.Entity;

namespace VotingViews.DTOs
{
    public class RegisteredUserDto
    {
        public int Id { get; set; }
        
        public string Email { get; set; }
        
        public Role Role { get; set; }
    }
}