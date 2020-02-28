using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Tailoring.entity
{
    public class User
    {
        [Required]
        public string Name { get; set; }

        [Required]
        
        public string Password { get; set; }

        
        [Required]
        public string MailId { get; set; }

        [Required]
        public string Address { get; set; }

        [Range(1, 100, ErrorMessage = "Age Should be min 1 and max 100")]
        [Required]
        public byte Age { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public long MobileNo { get; set; }
        [Required]
        public string City { get; set; }

    }
}
