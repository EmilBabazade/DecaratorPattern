namespace DecaratorPattern.Beverages.Condiments;

public class Whip(Beverage beverage) : CondimentDecorator(beverage)
{
    public override double Cost => _beverage.Cost + 0.10;

    public override string Description => "Whip " + _beverage.Description;
}
