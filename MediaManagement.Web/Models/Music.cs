using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MediaManagement.Web.Models
{
    public class Music : Media
    {
        [DisplayName("Album title")]
        public string AlbumName { get; set; }
    }
}
