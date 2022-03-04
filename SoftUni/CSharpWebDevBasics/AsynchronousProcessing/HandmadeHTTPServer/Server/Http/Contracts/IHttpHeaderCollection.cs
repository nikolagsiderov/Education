using System;
using System.Collections.Generic;
using System.Text;

namespace HandmadeHTTPServer.Server.Http.Contracts
{
    public interface IHttpHeaderCollection : IEnumerable<ICollection<HttpHeader>>
    {
        void Add(HttpHeader header);

        void Add(string key, string value);

        bool ContainsKey(string key);

        ICollection<HttpHeader> GetHeader(string key);
    }
}
