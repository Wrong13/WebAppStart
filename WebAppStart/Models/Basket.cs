namespace WebAppStart.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Price { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }

    }
}
