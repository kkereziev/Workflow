using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Data
{
    public class CurrentWorker
    {
        public int AssignmentID { get; set; }

        public Assignment Assignment { get; set; }

        public int WorkerID { get; set; }

        public Worker Worker { get; set; }
    }
}
