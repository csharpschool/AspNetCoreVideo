using AspNetCoreVideo.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreVideo.Data
{
    public class VideoDbContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }

        public VideoDbContext(DbContextOptions<VideoDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
