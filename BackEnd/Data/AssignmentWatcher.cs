using System;
using System.Collections.Generic;
using System.Linq;

namespace BackEnd.Data
{
    public class AssignmentWatcher
    {
        public int AssignmentID { get; set; }

        public Assignment Assignment { get; set; }

        public int WatcherID { get; set; }

        public Watcher Watcher { get; set; }
    }
}
