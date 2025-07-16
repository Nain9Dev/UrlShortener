using Microsoft.EntityFrameworkCore;
// Asegúrate de que este using coincide con el nombre de tu carpeta de modelos
using UrlShortener.Models;
using Microsoft.EntityFrameworkCore;

// Asegúrate de que el namespace coincide con la ubicación del archivo
namespace UrlShortener.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ShortenedUrl> ShortenedUrls { get; set; }
    }
}