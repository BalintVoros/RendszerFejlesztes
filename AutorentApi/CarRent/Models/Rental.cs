namespace AutorentApi.Models
{
    public class Rental
    {
        public int id { get; set; }
        public int userId { get; set; }
        public string autoId { get; set; }
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public string  created { get; set; }

    }
}