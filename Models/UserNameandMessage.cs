using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI.Models
{
    public partial class UserNameandMessage
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserMessage { get; set; }
        public DateTime TransactionDateTime { get; set; }
    }
}
