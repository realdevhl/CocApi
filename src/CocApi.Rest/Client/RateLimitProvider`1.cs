// <auto-generated>
/*
 * Clash of Clans API
 *
 * Check out <a href=\"https://developer.clashofclans.com/#/getting-started\" target=\"_parent\">Getting Started</a> for instructions and links to other resources. Clash of Clans API uses <a href=\"https://jwt.io/\" target=\"_blank\">JSON Web Tokens</a> for authorizing the requests. Tokens are created by developers on <a href=\"https://developer.clashofclans.com/#/account\" target=\"_parent\">My Account</a> page and must be passed in every API request in Authorization HTTP header using Bearer authentication scheme. Correct Authorization header looks like this: \"Authorization: Bearer API_TOKEN\". 
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Threading.Channels;

namespace CocApi.Rest.Client 
{
    /// <summary>
    /// Provides a token to the api clients. Tokens will be rate limited based on the provided TimeSpan.
    /// </summary>
    /// <typeparam name="TTokenBase"></typeparam>
    public class RateLimitProvider<TTokenBase> : TokenProvider<TTokenBase> where TTokenBase : TokenBase
    {
        internal Channel<TTokenBase> AvailableTokens { get; }

        /// <summary>
        /// Instantiates a ThrottledTokenProvider. Your tokens will be rate limited based on the token's timeout.
        /// </summary>
        /// <param name="container"></param>
        public RateLimitProvider(TokenContainer<TTokenBase> container) : base(container.Tokens)
        {
            foreach(TTokenBase token in _tokens)
                token.StartTimer(token.Timeout ?? TimeSpan.FromMilliseconds(40));

            BoundedChannelOptions options = new BoundedChannelOptions(_tokens.Length) 
            { 
                FullMode = BoundedChannelFullMode.DropWrite 
            };

            AvailableTokens = Channel.CreateBounded<TTokenBase>(options);

            for (int i = 0; i < _tokens.Length; i++)
                _tokens[i].TokenBecameAvailable += ((sender) => AvailableTokens.Writer.TryWrite((TTokenBase) sender));
        }

        internal override async System.Threading.Tasks.ValueTask<TTokenBase> GetAsync(System.Threading.CancellationToken? cancellation = null) 
            => await AvailableTokens.Reader.ReadAsync(cancellation.GetValueOrDefault()).ConfigureAwait(false);
    }
} 

