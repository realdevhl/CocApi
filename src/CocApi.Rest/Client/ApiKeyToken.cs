// <auto-generated>

#nullable enable

using System;

namespace CocApi.Rest.Client
{
    /// <summary>
    /// A token constructed from an apiKey.
    /// </summary>
    public class ApiKeyToken : TokenBase
    {
        private string _raw;

        /// <summary>
        /// The header that this token will be used with.
        /// </summary>
        public ClientUtils.ApiKeyHeader Header { get; }

        /// <summary>
        /// Constructs an ApiKeyToken object.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="header"></param>
        /// <param name="prefix"></param>
        /// <param name="timeout"></param>
        public ApiKeyToken(string value, ClientUtils.ApiKeyHeader header, string prefix = "Bearer ", TimeSpan? timeout = null) : base(timeout)
        {
            Header = header;
            _raw = $"{ prefix }{ value }";
        }

        /// <summary>
        /// Places the token in the header.
        /// </summary>
        /// <param name="request"></param>
        public virtual void UseInHeader(System.Net.Http.HttpRequestMessage request)
        {
            request.Headers.Add(ClientUtils.ApiKeyHeaderToString(Header), _raw);
        }

        /// <summary>
        /// Places the token in the query.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="uriBuilder"></param>
        /// <param name="parseQueryString"></param>
        public virtual void UseInQuery(System.Net.Http.HttpRequestMessage request, UriBuilder uriBuilder, System.Collections.Specialized.NameValueCollection parseQueryString)
        {
            parseQueryString[ClientUtils.ApiKeyHeaderToString(Header)] = Uri.EscapeDataString(_raw).ToString()!;
        }
    }
}
