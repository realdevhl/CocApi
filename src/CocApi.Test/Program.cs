﻿using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

using CocApi.Cache;
using System.Linq;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using Polly;
using Microsoft.Extensions.Configuration;

namespace CocApi.Test
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            if (args.Any())
                Console.WriteLine(args);

            CocApi.Library.HttpRequestResult += LogService.OnHttpRequestResult;
            CocApi.Library.Log += LogService.OnLog;
            CocApi.Cache.Library.Log += LogService.OnLog;

            await CreateHostBuilder(args).Build().RunAsync();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)

            // configure CocApi by naming your HttpClient, providing tokens, and defining the token timeout
            .ConfigureCocApi("cocApi", (host, tokenProvider) =>
            {
                for (int i = 0; i < 10; i++)
                {
                    string token = host.Configuration.GetValue<string>($"TOKEN_{i}");
                    
                    // you can go much lower than one second, fastest recommended speed is 33 milliseconds
                    tokenProvider.Tokens.Add(new TokenBuilder(token, TimeSpan.FromSeconds(1)));
                }
            })

            .ConfigureCocApiCache<ClansClient, PlayersClient, TimeToLiveProvider>(                
                // tell the cache library how to query your database
                provider => provider.Factory = new CacheDbContextFactory(),
                    c => {
                        c.ActiveWars.Enabled = false;
                        c.ClanMembers.Enabled = true;
                        c.Clans.Enabled = true;
                        c.NewCwlWars.Enabled = true;
                        c.NewWars.Enabled = false;
                        c.Wars.Enabled = false;
                        c.CwlWars.Enabled = false;
                    },
                    p => p.Enabled = false,
                    maxConcurrentEvents: 25)


            .ConfigureServices((hostBuilder, services) =>
            {
                // define the HttpClient named "cocApi" that CocApi will request
                services.AddHttpClient("cocApi", config =>
                {
                    config.BaseAddress = new Uri("https://api.clashofclans.com/v1");
                    config.Timeout = TimeSpan.FromSeconds(10);
                })
                // optionally configure Polly to handle timeouts and http request error handling
                .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(TimeSpan.FromSeconds(3)))
                .AddTransientHttpErrorPolicy(builder => builder.RetryAsync(2))
                .AddTransientHttpErrorPolicy(builder => builder.CircuitBreakerAsync(
                        handledEventsAllowedBeforeBreaking: 20,
                        durationOfBreak: TimeSpan.FromSeconds(30)
                ))

                // this property is important if you query the api very fast
                .ConfigurePrimaryHttpMessageHandler(sp => new SocketsHttpHandler() { MaxConnectionsPerServer = 100 });

                services.AddHostedService<TestService>();
            })
            .ConfigureLogging(o => o.ClearProviders());
    }
}