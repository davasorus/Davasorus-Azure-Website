using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DTOs
{
    public class AppPubReadDTO
    {
        public int Id { get; set; }
        public string AppName { get; set; }
        public string AppVersion { get; set; }
        public string ReleaseNotes { get; set; }
        public DateTime? TansactionDateTime { get; set; }
    }
}