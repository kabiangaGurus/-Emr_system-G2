using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Group2.Models
{
    public class categories
    {
        [Key]
        [MaxLength(50)]
        public string id { get; set; }
        [Required]
        public string catname { get; set; }
    }
}
