namespace StrategyDesignPattern.After;

public  class NavigationContext(INavigationStratgy navigationStratgy)
{
    private  INavigationStratgy _navigationStratgy = navigationStratgy;

    public void SwitchNavigationStrategy(INavigationStratgy navigationStratgy)
    {
        _navigationStratgy = navigationStratgy;
    }

    public Route Navigate (string origin, string destination)
    {
        return _navigationStratgy.Navigate(origin,destination);
    }
}

