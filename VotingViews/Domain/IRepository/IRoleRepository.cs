using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingViews.Model.Entity;

namespace VotingViews.Domain.IRepository
{
    public interface IRoleRepository
    {
        public Role AddRole(Role role);

        public Role GetRole(int id);

        public Role GetByName(string name);
    }
}
