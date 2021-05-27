using System;
using System.Collections.Generic;

namespace StreamWebPage.Models
{
    public partial class AppPub
    {
        public int Id { get; set; }
        public string AppName { get; set; }
        public string AppVersion { get; set; }
        public string ReleaseNotes { get; set; }
        public DateTime? TansactionDateTime { get; set; }
    }
}
