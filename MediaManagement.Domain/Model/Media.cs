using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MediaManagement.Web.Models
{
    public class Media
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
        public int TypeId { get; set; }
        [DisplayName("Genre")]
        public int GenreId { get; set; }
        [DisplayName("Your library")]
        public bool InLibrary { get; set; }
        [DisplayName("Favourite")]
        public bool IsFavourite { get; set; }


        public virtual Type Type { get; set; }
        public virtual Genre Genre { get; set; }
        public ICollection<MediaTag> MediaTags { get; set; }
    }
}
