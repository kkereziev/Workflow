namespace BackEnd.Migrations
{

    using System.Collections.Generic;

    public class Task : WorkflowDTO.Task
    {
        public Team Team { get; set; }

        public ICollection<CurrentWorker> CurrentWorkers { get; set; }

        public Priority Priority { get; set; }

        public virtual ICollection<TaskTag> TaskTags { get; set; }
    }
}
