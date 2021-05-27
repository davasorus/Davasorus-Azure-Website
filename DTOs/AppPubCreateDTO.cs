using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DTOs
{
    public class AppPubCreateDTO
    {
        [Required]
        public string AppName { get; set; }

        [Required]
        public string AppVersion { get; set; }

        [Required]
        public string ReleaseNotes { get; set; }
    }
}