namespace StrategyDesignPattern.After;

public interface INavigationStratgy
{
    Route Navigate(string origin, string destination);
}

