using MediaManagement.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Type = MediaManagement.Web.Models.Type;

namespace MediaManagement.Domain.Interfaces
{
    public interface IMediaRepository
    {
        int AddMedia(Media media);
        void UpdateMedia(Media newMedia, int oldMediaId);
        void DeleteMedia(int mediaId);
        IQueryable<Media> GetMediasByTypeId(int typeId);
        IQueryable<Media> GetMediasByGenreId(int genreId);
        Media GetMediaById(int mediaId);
        IQueryable<Tag> GetAllTags();
        IQueryable<Type> GetAllTypes();
    }
}
