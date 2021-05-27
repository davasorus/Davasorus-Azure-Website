using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI.Models
{
    public partial class UserName
    {
        public int UserNameId { get; set; }
        public string UserName1 { get; set; }
        public string IsSubscribed { get; set; }
        public int? SubLength { get; set; }
        public string IsModerator { get; set; }
        public string IsVip { get; set; }
        public string GivenBits { get; set; }
        public int? BitAmount { get; set; }
        public string Founder { get; set; }
        public DateTime TansactionDateTime { get; set; }
    }
}
