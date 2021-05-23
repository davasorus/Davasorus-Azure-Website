using System;

namespace StreamWebPage.Models
{
    public partial class AppPub
    {
        public int Id { get; set; }
        public string AppName { get; set; }
        public string AppVersion { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}