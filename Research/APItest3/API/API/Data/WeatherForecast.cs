namespace API.Data
{
    public class WeatherForecast
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int? TemperatureF { get; set; }

        public string? Summary { get; set; }
    }
}