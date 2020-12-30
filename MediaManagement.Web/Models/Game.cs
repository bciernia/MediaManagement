using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MediaManagement.Web.Models
{
    public class Game : Media
    {
        [DisplayName("Finished")]
        public bool IsPlayed { get; set; }
        [DisplayName("Platforms")]
        public string Platform { get; set; }

    }
}
