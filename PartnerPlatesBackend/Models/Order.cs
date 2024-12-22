namespace PartnerPlatesBackend.Models
{
    public class Order
    {
        public int Id { get; set; }

        public required DateOnly OrderDate { get; set; }

        public required decimal price { get; set; }
    }
}
