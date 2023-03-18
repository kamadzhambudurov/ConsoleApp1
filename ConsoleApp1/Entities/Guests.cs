namespace ConsoleApp1.Entities
{
    public class Guests
    {
        public int GuestId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public virtual List <Reservations> Reservations { get; set; }
    }
}
