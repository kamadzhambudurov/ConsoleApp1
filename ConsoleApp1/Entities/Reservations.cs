namespace ConsoleApp1.Entities
{
    public class Reservations
    {
        public int ReservationId { get; set; }
        public int RoomId { get; set; }
        public int GuestId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public virtual Rooms Room { get; set; }
        public virtual Guests Guest { get; set; }
        public virtual List <Payments> Payments { get; set; }
    }
}
