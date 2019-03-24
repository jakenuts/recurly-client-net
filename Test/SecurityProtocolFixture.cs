using System;
using System.Net;

namespace Recurly.Test
{
    public class SecurityProtocolFixture : IDisposable
    {
        protected SecurityProtocolType _oldProtocol;

        public SecurityProtocolFixture()
        {
            _oldProtocol = ServicePointManager.SecurityProtocol;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        public void Dispose()
        {
            ServicePointManager.SecurityProtocol = _oldProtocol;
        }
    }
}