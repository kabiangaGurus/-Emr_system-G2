using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Group2.Models
{
    public class roles
    {
        [Key]
        [MaxLength(50)]
        public string id { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
