namespace StrategyDesignPattern.After;

public partial class WalkingNavigationStrategy : INavigationStratgy
{
    public Route Navigate(string origin, string destination)
    {
        // complex process
        return new Route
        {
            Title = "via US-9 N",
            Origin = origin,
            Destination = destination,
            RoutePreference = RoutePreference.Driving,
            DistanceInKM = 601,
            Duration = TimeSpan.FromHours(123).Add(TimeSpan.FromMinutes(0)),
            Directions = new()
            {
                "Continue on Holland Tunnel to your destination in Manhattan, New York [10 min.] (4.6 km)",
                destination
            }
        };
    }
}