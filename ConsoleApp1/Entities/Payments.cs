namespace ConsoleApp1.Entities
{
    public class Payments
    {
        public int PaymentId { get; set; }
        public int ReservationId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public virtual Reservations Reservations { get; set; }
    }
}
