using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotingViews.Model.Entity;

namespace VotingViews.Models
{
    public class ElectionCodeViewModel
    {
        public List<Election> Elections { get; set; }

        public SelectList Codes { get; set; }

        public Guid ElectionCode { get; set; }

        public string SearchString { get; set; }
    }
}
