using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramApp.DataEntity.Models
{
    
    public class User
    {
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Password { get; set; }
        public string FcmToken { get; set; }
        public decimal WalletBalance { get; set; }
        public string ReferralCode { get; set; }
    }
}
