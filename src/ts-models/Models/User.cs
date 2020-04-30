namespace ts_models.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int GenderId { get; set; }

        public int AddressId { get; set; }
    }
}