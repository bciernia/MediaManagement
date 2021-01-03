using MediaManagement.Domain.Interfaces;
using MediaManagement.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Type = MediaManagement.Web.Models.Type;

namespace MediaManagement.Infrastructure.Repositories
{
    public class MediaRepository : IMediaRepository
    {
        private readonly Context _context;

        public MediaRepository(Context context)
        {
            _context = context;
        }

        public int AddMedia(Media media)
        {
            _context.Medias.Add(media);
            _context.SaveChanges();

            return media.Id;
        }

        public void UpdateMedia(Media newMedia, int oldMediaId)
        {
            var oldMedia = _context.Medias.FirstOrDefault(x => x.Id == oldMediaId);
            oldMedia = newMedia;
            _context.Update(oldMedia);
            _context.SaveChanges();
        }

        public void DeleteMedia(int mediaId)
        {
            var media = _context.Medias.Find(mediaId);

            if (media != null)
            {
                _context.Remove(media);
                _context.SaveChanges();
            }
        }

        public IQueryable<Media> GetMediasByTypeId(int typeId)
        {
            var medias = _context.Medias.Where(m => m.TypeId == typeId);
            return medias;
        }

        public IQueryable<Media> GetMediasByGenreId(int genreId)
        {
            var medias = _context.Medias.Where(m => m.GenreId == genreId);
            return medias;
        }

        public Media GetMediaById(int mediaId)
        {
            var media = _context.Medias.FirstOrDefault(m => m.Id == mediaId);
            return media;
        }

        public IQueryable<Tag> GetAllTags()
        {
            var tags = _context.Tags;
            return tags;
        }

        public IQueryable<Type> GetAllTypes()
        {
            var types = _context.Types;
            return types;
        }
    }
}
