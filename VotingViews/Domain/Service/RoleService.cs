using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingViews.Domain.IRepository;
using VotingViews.Domain.IService;

namespace VotingViews.Domain.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _role;

        public RoleService(IRoleRepository role)
        {
            _role = role;
        }
    }
}
