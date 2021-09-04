using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingViews.Context;
using VotingViews.Domain.IRepository;
using VotingViews.Model.Entity;

namespace VotingViews.Domain.Repository 
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationContext _context;

        public RoleRepository(ApplicationContext context)
        {
            _context = context;
        }
        public Role AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return role;
        }

        public Role GetRole(int id)
        {
            return _context.Roles.Find(id);
        }

        public Role GetByName(string name)
        {
            return _context.Roles.FirstOrDefault(r => r.Name.Equals(name));
        }
    }
}
