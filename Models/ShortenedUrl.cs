namespace UrlShortener.Models
{
    public class ShortenedUrl
    {
        public int Id { get; set; }
        public string LongUrl { get; set; }
        public string ShortCode { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
