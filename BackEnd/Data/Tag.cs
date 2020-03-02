namespace BackEnd.Data
{
    using System.Collections.Generic;

    public class Tag : WorkflowDTO.Tag
    {
        public virtual ICollection<AssignmentTag> AssignmentTags { get; set; }
    }
}
