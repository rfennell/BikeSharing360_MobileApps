namespace BikeSharing.Clients.Core
{
    public static class GlobalSettings
    {
        public const string AuthenticationEndpoint = "http://bikesharing-services-profiles2kttqgxlfnitk.azurewebsites.net/";
        public const string EventsEndpoint = "http://bikesharing-services-events2kttqgxlfnitk.azurewebsites.net/";
        public const string IssuesEndpoint = "http://bikesharing-services-feedback2kttqgxlfnitk.azurewebsites.net/";
        public const string RidesEndpoint = "http://bikesharing-services-rides2kttqgxlfnitk.azurewebsites.net/";

        public const string OpenWeatherMapAPIKey = "fc23a05cd393326b7c4843b73827e163";

        public const string HockeyAppAPIKeyForAndroid = "bbfa62da8cd74d2b9140e6e89f417154";
        public const string HockeyAppAPIKeyForiOS = "YOUR_HOCKEY_APP_ID";

        public const string SkypeBotAccount = "skype:YOUR_BOT_ID?chat";

        public const string BingMapsAPIKey = "AqP8gc6IGKVyO1PxQDOrKKtVeOYCBwy31yAzUd9zEQeda7kCKCJ0TVROyOimZZ1V";

        public static string City => "New York City";

        public static int TenantId = 1;
    }
}
