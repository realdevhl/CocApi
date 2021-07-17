# CocApi
A wrapper for [developer.clashofclans.com](https://developer.clashofclans.com/#/) written in .Net 5.0. 
CocApi is used to fetch results from the clash API. 
CocApi.Cache will cache responses in a database of your choice.
To keep objects up to date automatically and receive events on updates, add the tag to the village or clan ClientBase object.
 
## Help  
![Discord Banner 2](https://discordapp.com/api/guilds/701245583444279328/widget.png?style=banner2)

## Using the library
```csharp
// fetch commands directly query the api
Clan clan = await clansApi.FetchAsync("#clanTag");

// get commands query your cache database
Clan clan = await clansClient.GetOrFetchClanAsync("#clanTag");
```

## CocApi.Clash
Use the static class CocApi.Clash for various helpers including FormatTag, TryFormatTag, an array of all troop information, and parsing army links.

## Configuring CocApi
Use the IHostBuilder extension method ConfigureCocApi to add all the API endpoints to your service provider.
The TokenProvider object provides rate limiting on a per key basis.
Then you can use dependency injection to inject ClansApi, LabelsApi, LeaguesApi, LocationsApi, and PlayersApi. 
These classes allow you to query the API using the named HttpClient provided.
```csharp
private static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
	.ConfigureCocApi("cocApi", tokenProvider => { 
		tokenProvider.Tokens.Add(new TokenBuilder("your token", TimeSpan.FromMilliseconds(33)));
	})
	.ConfigureServices((hostBuilder, services) => 
	{
	    services.AddHttpClient("cocApi, httpClient =>
		{
			httpClient.BaseAddress = new Uri("https://api.clashofclans.com/v1");
			httpClient.Timeout = TimeSpan.FromSeconds(3);
		})
	}
```

## Configuring CocApi.Cache
Create a class that implements `IDesignTimeDbContextFactory<CocApi.Cache.CocApiCacheContext>`.
This tells the CocApi.Cache how to interact with your database.
Before running you will need to [create a migration](docs/scripts/cocapi-ef-migration.ps1) 
and run the [update](docs/scripts/cocapi-ef-update.ps1) on your database provider.
Modify these scripts to suit your needs. At the least you should edit the migration script to inject your connection string.
```ps1
dotnet ef migrations add YourMigrationName `
    --project $PSScriptRoot/YourProject `
    --context CocApi.Cache.CocApiCacheContext `
    -o ./OutputFolder `
    -- Your connection string or environment variable that will be injected into your IDesignTimeDbContextFactory.CreateDbContext args parameter
```

It is not required but recommended to create two classes that inherit ClansClientBase and PlayersClientBase from CocApi.Cache.
You probably also want these classes to implement IHostedService if you want to add code to StartAsync or StopAsync.
There are virtual TimeToLiveAsync methods which dictate how long an api response is stored for. 
There are also virtual HasUpdated methods which dictate if the object downloaded from the api has changed compared to the previous download.
When this method returns true, the new data will be written to the disk. If you don't care about the properties that changed, 
return false to prevent unnecessary writes to the hard drive.

Use the IHostBuilder extension method ConfigureCocApiCache to your service provider.
This requires that the CocApi is already added to the service provider as shown above. 
```csharp
// providing types ClansClient and PlayersClient is optional
.ConfigureCocApiCache<ClansClient, PlayersClient>(                
    // tell the cache library how to query your database
    provider => 
	{
		provider.Factory = new YourDbContextFactory();
		
		// use this method to inject your connection string from appsettings.json
		provider.DbContextArgs = new string[] { hostBuilder.Configuration.GetValue<string>("CocApi:Cache:ConnectionString") };
	},
        clansClient => {
            clansClient.ActiveWars.Enabled = false;
            clansClient.ClanMembers.Enabled = false;
            clansClient.Clans.Enabled = true;
            clansClient.NewCwlWars.Enabled = true;
            clansClient.NewWars.Enabled = false;
            clansClient.Wars.Enabled = false;
            clansClient.CwlWars.Enabled = false;
        },
        playersClient => playersClient.Enabled = false)
```

## Events
In OnClanUpdated you may utilize Clan.Donations, Clan.ClanMembersLeft, and Clan.ClanMembersJoined. In OnClanWarUpdated you may utilize ClanWar.NetAttacks.

## Monitors
### ActiveWarMonitor
Downloads the current war for a clan which is warring one of your tracked clans, but otherwise would not be downloaded. This ensures the most recent data is available. It may help if a tracked clan's war log is private. It also helps get the final war stats in the event the clan searches for a new war immediately.

### ClanMonitor
Downloads the clan, current war, war log, and league group for a given clan.

### ClanMembers
Iterates the Clan cached table searching for any clan with DownloadMembers enabled. Every player present in the clan will be downloaded. Players added to the Players table by this monitor will have Download set to **false**. When the village leaves the tracked clan, it will no longer update and will eventually be removed from the cache. If you wish to continue tracking these villages, on the OnClanUpdated event check for new members using `Clan.ClanMembersJoined(e.Stored, e.Fetched)` and add them to the PlayersClient with Download set to true.

### CwlWarMonitor
Iterates over the Wars cached table for any war with a war tag. Then queries the API and fires any appropriate updates.

### NewCwlWarMonitor
Queries the clan's league group from the cache to obtain the war tags. The API is then queried for each war tag. If the resulting war does not contain the desired clan, the war will be stored in memory. If the resulting war does contain the desired clan the war the NewWar event will be fired.

### NewWarMonitor
Queries the current war cache for any war not yet announced. Fires the NewWar event, and adds the war to the War table.

### PlayerMonitor
Iterates the Players cached table searching for players with Download set to true.

### WarMonitor
Iterates over the Wars cached table. Queries the CurrentWar cached table for both clans in the war. Takes the most recent of the two, checks if any changes have been downloaded, and fires the appropriate events.

## Migrating from version 1
Internally version 1 used SQLite. If you wish to import the cache from SQLite to your database, utilize the ImportDataToVersion2 method in either the ClansClient or PlayersClient. You only need to do this once. A future release of CocApi.Cache will remove this method and all traces of SQLite.

## Logging
Hook into CocApi.Library.HttpRequestResult, CocApi.Library.Log, and CocApi.Cache.Library.Log to receive events from the libraries.

## Disclaimer
This content is not affiliated with, endorsed, sponsored, or specifically approved by Supercell and Supercell is not responsible for it. For more information see [Supercell's Fan Content Policy](https://supercell.com/en/fan-content-policy/).