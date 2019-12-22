using CanvasArtWorks.Models;
using Microsoft.EntityFrameworkCore;

namespace CanvasArtWorks.Data
{
    public class ArtworkContext :DbContext
    {
        public ArtworkContext(DbContextOptions<ArtworkContext> options): base(options)
        {
        }
        public DbSet<Artwork> Artworks { get; set; }

    }
}