namespace ConsoleApp1.Entities
{
    public class Rooms
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public decimal RoomRate { get; set; }
        public virtual List <Reservations> Reservations { get; set; }
    }
}
