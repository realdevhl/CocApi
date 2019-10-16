﻿using System;
using System.Collections.Generic;
using System.IO;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using CocApiLibrary;
using System.Threading.Tasks;

namespace CocApiConsoleTest
{
    class Program
    {
        private static CocApi? _cocApi = null;

        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            LogService logService = host.Services.GetRequiredService<LogService>();

            logService.LogInformation("Press CTRL-C to exit");

            Console.CancelKeyPress += (s, e) => DoExitStuff(host.Services);

            InitializeCocApi(host.Services);

            host.Services.GetRequiredService<EventHandler>();

            var village = await _cocApi!.GetVillageAsync("#20PJ89JYU");

            host.Run();
        }        

        public static IHostBuilder CreateHostBuilder(string[] args) =>

            Host.CreateDefaultBuilder(args)

            .ConfigureServices((context, services) =>
            {
                services.AddSingleton<LogService>();

                services.AddSingleton<CocApi>();

                services.AddSingleton<EventHandler>();
            })
        ;

        private static void InitializeCocApi(IServiceProvider serviceProvider)
        {
            CocApiConfiguration cocApiConfiguration = new CocApiConfiguration
            {
                NumberOfUpdaters = 1,

                TimeToWaitForWebRequests = new TimeSpan(0, 0, 0, 10, 0)
            };

            cocApiConfiguration.Tokens.Add(File.ReadAllText(@"E:\Desktop\token.txt"));

            _cocApi = serviceProvider.GetRequiredService<CocApi>();

            _cocApi.Initialize(cocApiConfiguration, serviceProvider.GetRequiredService<LogService>());

            _cocApi.DownloadLeagueWars = DownloadLeagueWars.Auto;

            _cocApi.DownloadVillages = false;            
            
            List<string> clans = new List<string>
            {
                //"#8J82PV0C",  // FYSB Unbuckled
                //"#2C8V29YJ",  // Зеленоград
                //"#22VCPLR98", // LostMeta Power
                //"#8RJJ0C0Y"   // Rising Asylum
                //"#22G0JJR8"   // FYSB
                "#P989QU9P"     // Burlap Thongs
            };

            _cocApi.WatchClans(clans);

            _cocApi.BeginUpdatingClans();

            return;
        }

        private static void DoExitStuff(IServiceProvider services)
        {
            services.GetRequiredService<LogService>().LogInformation("{program}: Quiting, please wait...", "Program.cs");

            _cocApi?.Dispose();
        }

    }
}














































//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Threading.Tasks;
//using CocApiLibrary;
//using CocApiLibrary.Models;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Logging;

//namespace CocApiConsoleTest
//{
//    class Program
//    {
//        private static IServiceProvider _serviceProvider;

//        private static CocApi? _cocApi = null;

//        public static async Task Main(string[] args)
//        {
//            Console.WriteLine("Press ESC to stop");

//            _serviceProvider = ConfigureServices();

//            LogService logService = _serviceProvider.GetRequiredService<LogService>();

//            CocApiConfiguration cocApiConfiguration = new CocApiConfiguration
//            {
//                NumberOfUpdaters = 1,

//                TimeToWaitForWebRequests = new TimeSpan(0, 0, 0, 10, 0)
//            };

//            cocApiConfiguration.Tokens.Add(File.ReadAllText(@"E:\Desktop\token.txt"));

//            using CocApi cocApi = new CocApi(cocApiConfiguration, logService)
//            {
//                DownloadLeagueWars = DownloadLeagueWars.Auto,

//                DownloadVillages = false
//            };

//            cocApi.ClanChanged += CocApi_ClanChanged;

//            cocApi.IsAvailableChanged += CocApi_IsAvailableChanged;

//            cocApi.MembersJoined += CocApi_MembersJoined;

//            cocApi.ClanBadgeUrlChanged += CocApi_ClanBadgeUrlChanged;

//            cocApi.ClanLocationChanged += CocApi_ClanLocationChanged;

//            cocApi.NewAttacks += CocApi_NewAttacks;

//            cocApi.ClanPointsChanged += CocApi_ClanPointsChanged;

//            cocApi.ClanVersusPointsChanged += CocApi_ClanVersusPointsChanged;

//            cocApi.NewWar += CocApi_NewWar;

//            cocApi.WarIsAccessibleChanged += CocApi_WarIsAccessibleChanged;

//            cocApi.LeagueGroupTeamSizeChangeDetected += CocApi_LeagueSizeChangeDetected;

//            List<string> clans = new List<string>
//            {
//                //"#8J82PV0C",  // FYSB Unbuckled
//                //"#2C8V29YJ",  // Зеленоград
//                //"#22VCPLR98", // LostMeta Power
//                //"#8RJJ0C0Y"   // Rising Asylum
//                //"#22G0JJR8"     // FYSB
//                "#P989QU9P"
//            };

//            cocApi.WatchClans(clans);

//            cocApi.BeginUpdatingClans();

//            bool exit = false;

//            while (!exit)
//            {
//                while (!exit && !Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
//                {
//                    logService.LogInformation("{program}: Quiting, please wait...", "Program.cs");

//                    exit = true;

//                    break;
//                }
//            }



//            //just to remove the warnings

//            if (args.Count() > 0) { };

//            await Task.Delay(1);
//        }






//        private static IServiceProvider ConfigureServices()
//        {
//            return new ServiceCollection()
//                .AddSingleton<LogService>()
//                .BuildServiceProvider();
//        }

//        private static void CocApi_WarIsAccessibleChanged(ICurrentWarAPIModel currentWarAPIModel)
//        {
//            Console.WriteLine($"War is accessible changed:{currentWarAPIModel.Flags.WarIsAccessible}");
//        }

//        private static void CocApi_NewWar(ICurrentWarAPIModel currentWarAPIModel)
//        {
//            Console.WriteLine($"New War: {currentWarAPIModel.WarID}");
//        }

//        private static void CocApi_ClanVersusPointsChanged(ClanAPIModel oldClan, int newClanVersusPoints)
//        {
//            Console.WriteLine($"{oldClan.Tag} {oldClan.Name} new clan versus points: {newClanVersusPoints}");
//        }

//        private static void CocApi_ClanPointsChanged(ClanAPIModel oldClan, int newClanPoints)
//        {
//            Console.WriteLine($"{oldClan.Tag} {oldClan.Name} new clan points: {newClanPoints}");
//        }

//        private static void CocApi_ClanLocationChanged(ClanAPIModel oldClan, ClanAPIModel newClan)
//        {
//            Console.WriteLine(newClan.Location?.Name);
//        }

//        private static void CocApi_ClanBadgeUrlChanged(ClanAPIModel oldClan, ClanAPIModel newClan)
//        {
//            Console.WriteLine(newClan.BadgeUrls?.Large);
//        }

//        private static void CocApi_ClanChanged(ClanAPIModel oldClan, ClanAPIModel newClan)
//        {
//            Console.WriteLine($"{oldClan.Tag} {oldClan.Name} changed.");
//        }

//        private static void CocApi_NewAttacks(ICurrentWarAPIModel currentWarAPIModel, List<AttackAPIModel> attackAPIModels)
//        {
//            Console.WriteLine($"new attacks: {attackAPIModels.Count()}");
//        }

//        private static void CocApi_MembersJoined(ClanAPIModel clanAPIModel, List<MemberListAPIModel> memberListAPIModels)
//        {
//            Console.WriteLine($"{memberListAPIModels.Count()} members joined.");
//        }

//        private static void CocApi_IsAvailableChanged(bool isAvailable)
//        {
//            Console.WriteLine($"CocApi isAvailable: {isAvailable}");
//        }

//        private static void CocApi_LeagueSizeChangeDetected(LeagueGroupAPIModel leagueGroupAPIModel)
//        {
//            Console.WriteLine($"League Size changed: {leagueGroupAPIModel.TeamSize}");
//        }
//    }
//}
