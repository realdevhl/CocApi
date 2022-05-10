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
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using CocApi.Rest.Models;

namespace CocApi.Rest.Client
{
    /// <summary>
    /// Provides hosting configuration for CocApi.Rest
    /// </summary>
    public class HostConfiguration<TClansApi, TGoldpassApi, TLabelsApi, TLeaguesApi, TLocationsApi, TPlayersApi>
        where TClansApi : class, IApis.IClansApi
        where TGoldpassApi : class, IApis.IGoldpassApi
        where TLabelsApi : class, IApis.ILabelsApi
        where TLeaguesApi : class, IApis.ILeaguesApi
        where TLocationsApi : class, IApis.ILocationsApi
        where TPlayersApi : class, IApis.IPlayersApi
    {
        private readonly IServiceCollection _services;
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions();

        internal bool HttpClientsAdded { get; private set; }

        /// <summary>
        /// Instantiates the class 
        /// </summary>
        /// <param name="services"></param>
        public HostConfiguration(IServiceCollection services)
        {
            _services = services;
            _jsonOptions.Converters.Add(new JsonStringEnumConverter());
            _jsonOptions.Converters.Add(new DateTimeJsonConverter());
            _jsonOptions.Converters.Add(new DateTimeNullableJsonConverter());
            _jsonOptions.Converters.Add(new BadgeUrlsJsonConverter());
            _jsonOptions.Converters.Add(new ClanJsonConverter());
            _jsonOptions.Converters.Add(new ClanListJsonConverter());
            _jsonOptions.Converters.Add(new ClanMemberJsonConverter());
            _jsonOptions.Converters.Add(new ClanRankingJsonConverter());
            _jsonOptions.Converters.Add(new ClanRankingListJsonConverter());
            _jsonOptions.Converters.Add(new ClanVersusRankingJsonConverter());
            _jsonOptions.Converters.Add(new ClanVersusRankingListJsonConverter());
            _jsonOptions.Converters.Add(new ClanWarJsonConverter());
            _jsonOptions.Converters.Add(new ClanWarAttackJsonConverter());
            _jsonOptions.Converters.Add(new ClanWarLeagueClanJsonConverter());
            _jsonOptions.Converters.Add(new ClanWarLeagueClanMemberJsonConverter());
            _jsonOptions.Converters.Add(new ClanWarLeagueGroupJsonConverter());
            _jsonOptions.Converters.Add(new ClanWarLeagueRoundJsonConverter());
            _jsonOptions.Converters.Add(new ClanWarLogJsonConverter());
            _jsonOptions.Converters.Add(new ClanWarLogEntryJsonConverter());
            _jsonOptions.Converters.Add(new ClanWarMemberJsonConverter());
            _jsonOptions.Converters.Add(new ClientErrorJsonConverter());
            _jsonOptions.Converters.Add(new GoldPassSeasonJsonConverter());
            _jsonOptions.Converters.Add(new GroupStateConverter());
            _jsonOptions.Converters.Add(new GroupStateNullableConverter());
            _jsonOptions.Converters.Add(new IconUrlsJsonConverter());
            _jsonOptions.Converters.Add(new LabelJsonConverter());
            _jsonOptions.Converters.Add(new LabelsObjectJsonConverter());
            _jsonOptions.Converters.Add(new LanguageJsonConverter());
            _jsonOptions.Converters.Add(new LeagueJsonConverter());
            _jsonOptions.Converters.Add(new LeagueListJsonConverter());
            _jsonOptions.Converters.Add(new LeagueSeasonJsonConverter());
            _jsonOptions.Converters.Add(new LeagueSeasonListJsonConverter());
            _jsonOptions.Converters.Add(new LegendLeagueTournamentSeasonResultJsonConverter());
            _jsonOptions.Converters.Add(new LocationJsonConverter());
            _jsonOptions.Converters.Add(new LocationListJsonConverter());
            _jsonOptions.Converters.Add(new PlayerJsonConverter());
            _jsonOptions.Converters.Add(new PlayerAchievementProgressJsonConverter());
            _jsonOptions.Converters.Add(new PlayerClanJsonConverter());
            _jsonOptions.Converters.Add(new PlayerItemLevelJsonConverter());
            _jsonOptions.Converters.Add(new PlayerLegendStatisticsJsonConverter());
            _jsonOptions.Converters.Add(new PlayerRankingJsonConverter());
            _jsonOptions.Converters.Add(new PlayerRankingClanJsonConverter());
            _jsonOptions.Converters.Add(new PlayerRankingListJsonConverter());
            _jsonOptions.Converters.Add(new PlayerVersusRankingJsonConverter());
            _jsonOptions.Converters.Add(new PlayerVersusRankingListJsonConverter());
            _jsonOptions.Converters.Add(new RecruitingTypeConverter());
            _jsonOptions.Converters.Add(new RecruitingTypeNullableConverter());
            _jsonOptions.Converters.Add(new ResultConverter());
            _jsonOptions.Converters.Add(new ResultNullableConverter());
            _jsonOptions.Converters.Add(new RoleConverter());
            _jsonOptions.Converters.Add(new RoleNullableConverter());
            _jsonOptions.Converters.Add(new VerifyTokenRequestJsonConverter());
            _jsonOptions.Converters.Add(new VerifyTokenResponseJsonConverter());
            _jsonOptions.Converters.Add(new WarClanJsonConverter());
            _jsonOptions.Converters.Add(new WarClanLogEntryJsonConverter());
            _jsonOptions.Converters.Add(new WarFrequencyConverter());
            _jsonOptions.Converters.Add(new WarFrequencyNullableConverter());
            _jsonOptions.Converters.Add(new WarLeagueJsonConverter());
            _jsonOptions.Converters.Add(new WarLeagueListJsonConverter());
            _jsonOptions.Converters.Add(new WarPreferenceConverter());
            _jsonOptions.Converters.Add(new WarPreferenceNullableConverter());
            _jsonOptions.Converters.Add(new WarStateConverter());
            _jsonOptions.Converters.Add(new WarStateNullableConverter());
            _jsonOptions.Converters.Add(new WarTypeConverter());
            _jsonOptions.Converters.Add(new WarTypeNullableConverter());
            _services.AddSingleton(new JsonSerializerOptionsProvider(_jsonOptions));
            _services.AddSingleton<IApiFactory, ApiFactory>();
            _services.AddTransient<TClansApi, TClansApi>();
            _services.AddTransient<TGoldpassApi, TGoldpassApi>();
            _services.AddTransient<TLabelsApi, TLabelsApi>();
            _services.AddTransient<TLeaguesApi, TLeaguesApi>();
            _services.AddTransient<TLocationsApi, TLocationsApi>();
            _services.AddTransient<TPlayersApi, TPlayersApi>();
        }

        /// <summary>
        /// Configures the HttpClients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        public HostConfiguration<TClansApi, TGoldpassApi, TLabelsApi, TLeaguesApi, TLocationsApi, TPlayersApi> AddCocApiHttpClients
        (
            Action<HttpClient>? client = null, Action<IHttpClientBuilder>? builder = null)
        {
            if (client == null)
                client = c => c.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS);

            List<IHttpClientBuilder> builders = new List<IHttpClientBuilder>();

            builders.Add(_services.AddHttpClient<IApis.IClansApi, TClansApi>(client));
            builders.Add(_services.AddHttpClient<IApis.IGoldpassApi, TGoldpassApi>(client));
            builders.Add(_services.AddHttpClient<IApis.ILabelsApi, TLabelsApi>(client));
            builders.Add(_services.AddHttpClient<IApis.ILeaguesApi, TLeaguesApi>(client));
            builders.Add(_services.AddHttpClient<IApis.ILocationsApi, TLocationsApi>(client));
            builders.Add(_services.AddHttpClient<IApis.IPlayersApi, TPlayersApi>(client));
            
            if (builder != null)
                foreach (IHttpClientBuilder instance in builders)
                    builder(instance);

            HttpClientsAdded = true;

            return this;
        }

        /// <summary>
        /// Configures the JsonSerializerSettings
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public HostConfiguration<TClansApi, TGoldpassApi, TLabelsApi, TLeaguesApi, TLocationsApi, TPlayersApi> ConfigureJsonOptions(Action<JsonSerializerOptions> options)
        {
            options(_jsonOptions);

            return this;
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="token"></param>
        /// <returns></returns>
        public HostConfiguration<TClansApi, TGoldpassApi, TLabelsApi, TLeaguesApi, TLocationsApi, TPlayersApi> AddTokens<TTokenBase>(TTokenBase token) where TTokenBase : TokenBase
        {
            return AddTokens(new TTokenBase[]{ token });
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public HostConfiguration<TClansApi, TGoldpassApi, TLabelsApi, TLeaguesApi, TLocationsApi, TPlayersApi> AddTokens<TTokenBase>(IEnumerable<TTokenBase> tokens) where TTokenBase : TokenBase
        {
            TokenContainer<TTokenBase> container = new TokenContainer<TTokenBase>(tokens);
            _services.AddSingleton(services => container);

            return this;
        }

        /// <summary>
        /// Adds a token provider to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenProvider"></typeparam>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <returns></returns>
        public HostConfiguration<TClansApi, TGoldpassApi, TLabelsApi, TLeaguesApi, TLocationsApi, TPlayersApi> UseProvider<TTokenProvider, TTokenBase>() 
            where TTokenProvider : TokenProvider<TTokenBase>
            where TTokenBase : TokenBase
        {
            _services.AddSingleton<TTokenProvider>();
            _services.AddSingleton<TokenProvider<TTokenBase>>(services => services.GetRequiredService<TTokenProvider>());

            return this;
        }
    }
}

