using LoginPj.Model;

namespace LoginPj.Service.Registration;

internal interface IRegistration
{
    Credentials AddCredential(Credentials credential);

}
