using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gharelu_Utpadan.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [DisplayName("Mobile Number")]
        public string MobileNumber { get; set; }
        [Required]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [StringLength(15,ErrorMessage = "Must be at least 8 characters",MinimumLength =8)]
        public string Password { get; set; }
        [Required]
        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [StringLength(15, ErrorMessage = "Must be at least 8 characters", MinimumLength = 8)]
        [Compare("Password",ErrorMessage = "Password does not match" )]
        public string ConfirmPassword { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
    }
}