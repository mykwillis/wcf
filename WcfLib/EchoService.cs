using System;
using System.ServiceModel;

namespace WcfLib
{
    public class EchoService : IEcho
    {
        public string Echo(string s)
        {
            return "You said: " + s;
        }
    }
}