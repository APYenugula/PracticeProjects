namespace DbConnector
{
    public interface IDatabase
    {
        string Info();
        string WelcomeMsg(string userID);
    }
}