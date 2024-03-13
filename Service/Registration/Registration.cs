using LoginPj.Brokers;
using LoginPj.Model;
using System.Net;

namespace LoginPj.Service.Registration;

internal class Registration : IRegistration
{
    
        private readonly ILogBroker logBroker;

    public Registration()
    {
        logBroker = new LogBroker();
    }
    public Credentials AddCredential(Credentials credential)
    {

        if(credential is null)
        {
           return CreateAndLogInvalidCredential();
        }
        else
        {
            return ValidateAndAddCredential(credential);
        }

        
    }

    private Credentials CreateAndLogInvalidCredential()
    {
        Console.WriteLine("Contact is invalid");

        return new Credentials();
    }

    private Credentials ValidateAndAddCredential(Credentials credential)
    {
        if (string.IsNullOrWhiteSpace(credential.Username)
            || string.IsNullOrWhiteSpace(credential.Password))
        {
            Console.WriteLine("Contact details missing.");

            return new Credentials();
        }
        else
        {
            return this.logBroker.AddCredential(credential);
        }
    }
}
