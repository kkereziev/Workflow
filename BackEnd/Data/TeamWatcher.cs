using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Migrations
{
    public class TeamWatcher
    {
        public int TeamID { get; set; }

        public Team Team { get; set; }

        public int WatcherID { get; set; }

        public Watcher Watcher { get; set; }
    }
}
