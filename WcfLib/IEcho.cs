using System;
using System.ServiceModel;

namespace WcfLib
{
    [ServiceContract(Namespace = "http://www.datacore.com.example")]
    public interface IEcho
    {
        [OperationContract]
        string Echo(string s);
    }
}