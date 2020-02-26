namespace BackEnd.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Priority : WorkflowDTO.Priority
    {
        [Required]
        public Team Team { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
