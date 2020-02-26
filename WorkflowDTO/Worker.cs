namespace WorkflowDTO
{
    using System.ComponentModel.DataAnnotations;

    public class Worker
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(400)]
        public string Bio { get; set; }

        [StringLength(1000)]
        public virtual string WebPage { get; set; }
    }
}