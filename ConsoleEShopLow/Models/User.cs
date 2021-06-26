namespace ConsoleEShopLow.Models
{
   public class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public Role CurentRole { get; set; }
        public string Password { get; set; }
    }
}
