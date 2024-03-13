
using LoginPj.Model;

namespace LoginPj.Service.Login;

internal interface ILogin
{
    bool CheckLogins(Credentials credentials);
}
