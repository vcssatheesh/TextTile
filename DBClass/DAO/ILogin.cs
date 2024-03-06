namespace DBClass.DAO
{
    public interface ILogin
    {
        Task<bool> DoLogin(string username, string password);
    }
}
