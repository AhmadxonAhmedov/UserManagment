
using LoginPj.Brokers;
using LoginPj.Model;

namespace LoginPj.Service.Login;

internal class Login : ILogin
{
    private readonly ILogBroker logBroker;

    public Login()
    {
        this.logBroker = new LogBroker();
    }

    public bool CheckLogins(Credentials credentials)
    {
        foreach (Credentials credentials1 in logBroker.ViewAllCredtinals())
        {
            if(credentials.Username == credentials1.Username && credentials.Password == credentials1.Password )
            {
                return true;
            }
        }
             return false;
    }
}
