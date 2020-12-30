using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MediaManagement.Web.Models
{
    public class Movie : Media
    {
        [DisplayName("Watched")]
        public bool IsWatched { get; set; }

    }
}
