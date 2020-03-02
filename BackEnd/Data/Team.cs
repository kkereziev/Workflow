using System;
using System.Collections.Generic;
using System.Linq;

namespace BackEnd.Data
{
    public class Team : WorkflowDTO.Team
    {
        public virtual ICollection<Priority> Priorities { get; set; }

        public virtual ICollection<Worker> Workers { get; set; }

        public virtual ICollection<Assignment> Assignments { get; set; }

        public virtual ICollection<TeamWatcher> TeamWatchers { get; set; }
    }
}
