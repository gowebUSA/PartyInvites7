using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please enter your email adderess")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Please enter your email address")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please enter your phone")]
        public string Phone { get; set; }


        [Required(ErrorMessage = "Please specify if you are attending")]
        public bool? WillAttend { get; set; }
    }
}
