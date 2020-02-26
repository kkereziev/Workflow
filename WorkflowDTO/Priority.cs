namespace WorkflowDTO
{
    using System.ComponentModel.DataAnnotations;

    public class Priority
    {
        public int PriorityID { get; set; }

        [Required]
        public int TeamID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }
    }
}
