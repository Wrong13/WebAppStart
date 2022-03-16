namespace WebAppStart.Models
{
    public class User
    {
        public User()
        {
            this.Baskets = new HashSet<Basket>();
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<Basket> Baskets { get; set; }
    }
}
