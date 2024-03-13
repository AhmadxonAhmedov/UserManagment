using LoginPj.Model;


namespace LoginPj.Brokers;

internal class LogBroker : ILogBroker
{
    private const string path = @"C:\Users\Asus\Desktop\c#\LoginPj\Assest\File.txt";

    public LogBroker()
    {
        IsFileExists();
    }

    private Credentials[] credentials =
    {

    };
    Credentials[] ILogBroker.ViewAllCredtinals() 
        => credentials;
    
    


    public Credentials AddCredential(Credentials credential)
    {
        string credentialLine = $"{credential.Username}*{credential.Password}\n";
        File.AppendAllText(path, credentialLine);

        return credential;
    }

    private void IsFileExists()
    {
        bool fileExists = File.Exists(path);

        if (fileExists is false)
        {
            File.Create(path).Close();
        }
    }

   
}
