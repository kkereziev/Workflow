using System;
using System.Collections.Generic;
using System.Linq;

namespace BackEnd.Migrations
{
    public class TaskWatcher
    {
        public int TaskID { get; set; }

        public Task Task { get; set; }

        public int WatcherID { get; set; }

        public Watcher Watcher { get; set; }
    }
}
