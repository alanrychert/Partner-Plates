namespace PartnerPlatesBackend.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public required DateOnly PaymentDate { get; set; }

        //public bool Confirmed { get; set; } = false;

        //public required decimal Amount { get; set; }
    }
}
