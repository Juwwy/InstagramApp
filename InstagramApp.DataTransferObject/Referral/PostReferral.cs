using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramApp.DataTransferObject.Referral
{
    public class PostReferral
    {
        public string Referrer { get; set; }
        public string Referee { get; set; }
        public decimal Point { get; set; }
    }
}
