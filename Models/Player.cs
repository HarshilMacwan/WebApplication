using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAssignment1.Models
{
    public class Player
    {
        [Required(ErrorMessage = "Please Enter Player's Firse Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Enter Player's Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please Enter Age of Player")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Please Enter Player's Position")]
        public string Position { get; set; }
        [Required(ErrorMessage = "Please Enter Player's Phone No.")]
        public string Phone { get; set; }
    }
}
