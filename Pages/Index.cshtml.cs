using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
// Asegúrate de que estos usings coinciden con los nombres de tus carpetas
using UrlShortener.Data;
using UrlShortener.Models;

// El namespace debe ser el de la carpeta Pages
namespace UrlShortener.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string? LongUrl { get; set; } // Añadido '?' para permitir nulos al inicio
        public ShortenedUrl? NewUrl { get; set; } // Añadido '?' para permitir nulos al inicio

        public async Task<IActionResult> OnPostAsync()
        {
            if (string.IsNullOrEmpty(LongUrl))
            {
                return Page();
            }

            var shortCode = Guid.NewGuid().ToString("N").Substring(0, 7);

            var url = new ShortenedUrl
            {
                LongUrl = LongUrl,
                ShortCode = shortCode
            };

            _context.ShortenedUrls.Add(url);
            await _context.SaveChangesAsync();

            NewUrl = url;
            // Para mostrar la URL completa al usuario
            NewUrl.ShortCode = $"{Request.Scheme}://{Request.Host}/{url.ShortCode}";

            return Page();
        }
    }
}