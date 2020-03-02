namespace BackEnd.Data
{

    using System.Collections.Generic;

    public class Assignment : WorkflowDTO.Assignment
    {
        public Team Team { get; set; }

        public ICollection<CurrentWorker> CurrentWorkers { get; set; }

        public Priority Priority { get; set; }

        public virtual ICollection<AssignmentTag> AssignmentTags { get; set; }
    }
}
