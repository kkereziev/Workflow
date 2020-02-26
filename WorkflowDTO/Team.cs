
namespace WorkflowDTO
{
    using System.ComponentModel.DataAnnotations;

    public class Team
    {

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }
    }
}
