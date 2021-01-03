using MediaManagement.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Type = MediaManagement.Web.Models.Type;

namespace MediaManagement.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<MediaTag> MediaTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Type> Types { get; set; }
        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<MediaTag>()
                .HasKey(x => new { x.MediaId, x.TagId });

            builder.Entity<MediaTag>()
                .HasOne<Media>(x => x.Media)
                .WithMany(x => x.MediaTags)
                .HasForeignKey(x => x.MediaId);

            builder.Entity<MediaTag>()
                .HasOne<Tag>(x => x.Tag)
                .WithMany(x => x.MediaTags)
                .HasForeignKey(x => x.TagId);
        }
    }
}
