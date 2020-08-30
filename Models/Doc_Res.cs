using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Group2.Models
{
    public class Doc_Res
    {
        [Key]
        [MaxLength(50)]
        public string Id { get; set; }
        [Required]
        [DisplayName("Full Name")]
        public string fULL_NAME { get; set; }
        [Required]
        [DisplayName("Username")]
        public string uSERNAME { get; set; }
        public string ROLE { get; set; }
        [Required]
        [DisplayName("Service Number")]
        public string serviceNo { get; set; }
        [Required]
        public string PHONE { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string PASSWORD { get; set; }
    }
}
