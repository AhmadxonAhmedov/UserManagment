

using LoginPj.Model;

namespace LoginPj.Brokers;

internal interface ILogBroker
{
    Credentials[] ViewAllCredtinals();
    public Credentials AddCredential(Credentials credential);
}
