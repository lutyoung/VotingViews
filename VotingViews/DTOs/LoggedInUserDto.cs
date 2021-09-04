using System;
using VotingViews.Model.Entity;

namespace VotingViews.DTOs
{
    public class LoggedInUserDto
    {
        public int Id { get; set; }
        public Role Role { get; set; }
    }
}