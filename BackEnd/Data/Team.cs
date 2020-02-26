using System;
using System.Collections.Generic;
using System.Linq;

namespace BackEnd.Migrations
{
    public class Team : WorkflowDTO.Team
    {
        public virtual ICollection<Priority> Priorities { get; set; }

        public virtual ICollection<Worker> Workers { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }

        public virtual ICollection<TeamWatcher> TeamWatchers { get; set; }
    }
}
