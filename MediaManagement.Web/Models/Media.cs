using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MediaManagement.Web.Models
{
    public abstract class Media
    {
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Title")]
        public string Name { get; set; }
        [DisplayName("Creator")]
        public string Creator { get; set; }
        [DisplayName("Release year")]
        public int ReleaseYear { get; set; }
        [DisplayName("Type")]
        public string Type { get; set; }
        [DisplayName("Favourite")]
        public bool IsFavourite { get; set; }
    }
}
