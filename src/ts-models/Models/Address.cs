namespace ts_models.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Address1 {get; set; }
        public string Address2 { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public string Phone { get; set; }
        public string ZipCode { get; set; }
    }
}