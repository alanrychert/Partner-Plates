namespace PartnerPlatesBackend.Models
{
    public class Provider
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string PhoneNumber { get; set; }
    }
}
