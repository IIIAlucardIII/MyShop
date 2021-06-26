namespace ConsoleEShopLow.Interfaces
{
    public interface IAuthorizationService
    {
        void LogIn(string login, string password);
        void LogOut();
    }
}
