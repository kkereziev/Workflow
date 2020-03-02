using System;
using System.Collections.Generic;
using System.Linq;

namespace BackEnd.Data
{
    public class AssignmentTag
    {
        public int AssignmentID { get; set; }

        public Assignment Assignment { get; set; }

        public int TagID { get; set; }

        public Tag Tag { get; set; }
    }
}
