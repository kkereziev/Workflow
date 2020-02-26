using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WorkflowDTO
{
    public class Tags
    {
        public int ID { get; set; }

        [Required]
        [StringLength(32)]
        public string Name { get; set; }
    }
}
