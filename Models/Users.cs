using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Group2.Models
{
    public class Users
    {
        [Key]
        [MaxLength(50)]
        public string Id { get; set; }
        [Required]
        [DisplayName("Full Name")]
        public string fULL_NAME { get; set; }
        [Required]
        [DisplayName("Date of birth")]
        public string d_O_b { get; set; }
        [Required]
        [DisplayName("Gender")]
        public string GENDER { get; set; }
        [Required]
        [DisplayName("Username")]
        public string uSERNAME { get; set; }
        [Required]
        [DisplayName("Role")]
        public string ROLE { get; set; }
        [Required]
        public string uniqueId { get; set; }
        [Required]
        [DisplayName("Location")]
        public string LOCATION { get; set; }
        [Required]
        [DisplayName("Phone")]
        public string PHONE { get; set; }
      
    }
}
