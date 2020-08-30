using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Group2.Models
{
    public class UserDetails
    {
        [Key]
        [MaxLength(50)]
        public string Id { get; set; }
        [Required]
        [DisplayName("UserId")]
        public string UswerId { get; set; }
        [Required]
        [DisplayName("date")]
        public string date { get; set; }
        [DisplayName("Docter")]
        public string DocId { get; set; }
        [DisplayName("Institution Name")]
        public string Institution { get; set; }
        [DisplayName("Diagnosed?")]
        public string IsDiagnosed { get; set; }
        [DisplayName("Diagnosed With")]
        public string Problem { get; set; }
      
        [Required]
        public string Comment { get; set; }
    }
}
