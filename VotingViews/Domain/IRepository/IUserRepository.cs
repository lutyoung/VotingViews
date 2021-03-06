using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingViews.Model.Entity;

namespace VotingViews.Domain.IRepository
{
    public interface IUserRepository
    {
        public User CreateUser(User user);

        public User FindByEmail(string email);

        public User FindById(int id);

        public List<User> GetAll();

        public void DeleteUser(int id);

        public User UpdateUser(User user);
    }
}
