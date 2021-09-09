using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramApp.DataTransferObject.User
{
    public class PostUser
    {
       
        [Required(ErrorMessage ="Firstname cannot be empty!")]
        [MaxLength(125)]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Lastname cannot be empty!")]
        [MaxLength(125)]
        public string Lastname { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Email address cannot be empty!")]
        [MaxLength(125)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Username cannot be empty!")]
        [MaxLength(125)]
        public string Username { get; set; }
        [Required(ErrorMessage = "Phone number cannot be empty")]
        [MaxLength(125)]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "Password cannot be empty")]
        [MaxLength(125)]
        public string Password { get; set; }
        public string FcmToken { get; set; }
        public decimal WalletBalance { get; set; }
        public string ReferralCode { get; set; }
    }
}
