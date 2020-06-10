using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAssignment1.Models
{
    public class Club
    {
        [Required(ErrorMessage = "Please Enter Club Name")]
        public String ClubName { get; set; }

        [Required(ErrorMessage = "Please Enter Website")]
        public String Website { get; set; }

        [Required(ErrorMessage = "Please Enter Your Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "please Enter Valid Email Address")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Please Enter Your Phone number")]
        public String Phone { get; set; }

        //   public List<Player> players { get; set; }

    }
    
}
