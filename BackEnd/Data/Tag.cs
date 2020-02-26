namespace BackEnd.Data
{
    using System.Collections.Generic;

    public class Tag : WorkflowDTO.Tag
    {
        public virtual ICollection<TaskTag> TaskTags { get; set; }
    }
}
