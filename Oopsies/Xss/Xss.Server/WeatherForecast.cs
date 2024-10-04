using Microsoft.AspNetCore.Mvc;

namespace Xss.Server
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public IActionResult Search(string query)
        {
            // assume query is '<script>alert('XSS')</script>'
            string result = "You searched for: " + query;
            return new ContentResult() { Content = result };
        }
    }
}
