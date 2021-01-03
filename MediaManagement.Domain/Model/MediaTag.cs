using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaManagement.Web.Models
{
    public class MediaTag
    {
        public int MediaId { get; set; }
        public Media Media { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
