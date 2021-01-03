using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaManagement.Web.Models
{
    public class Type
    {
        public int Id { get; set; }
        public string Game { get; set; }
        public string Movie { get; set; }
        public string Music { get; set; }

        public virtual ICollection<Media> Medias { get; set; }
    }
}
