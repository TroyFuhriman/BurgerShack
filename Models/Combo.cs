namespace BurgerShack.Models
{
    public class DbCombo
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public int BurgerId { get; set; }
        public int SideId { get; set; }
    }

    // public class Combo : DbCombo
    // {
    //     public Burger Burger { get; set; }
    //     public Side Side { get; set; }
    // }
}