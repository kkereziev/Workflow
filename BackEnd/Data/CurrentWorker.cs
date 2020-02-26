using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Migrations
{
    public class CurrentWorker
    {
        public int TaskID { get; set; }

        public Task Task { get; set; }

        public int WorkerID { get; set; }

        public Worker Worker { get; set; }
    }
}
