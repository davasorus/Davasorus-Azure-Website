using System;
using System.Collections.Generic;

namespace StreamWebPage.Models
{
    public partial class GameName
    {
        public int Id { get; set; }
        public string GameName1 { get; set; }
        public string GameTypeName { get; set; }
        public int? GameTypeId { get; set; }
    }
}
