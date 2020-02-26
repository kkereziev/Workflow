using System;
using System.Collections.Generic;
using System.Linq;

namespace BackEnd.Migrations
{
    public class TaskTag
    {
        public int TaskID { get; set; }

        public Task Task { get; set; }

        public int TagID { get; set; }

        public Tag Tag { get; set; }
    }
}
