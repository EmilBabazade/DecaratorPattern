namespace DecaratorPattern.Beverages.Condiments;

public class Mocha(Beverage beverage) : CondimentDecorator(beverage)
{
    public override double Cost => _beverage.Cost + 0.20;

    public override string Description => "Mocha " + _beverage.Description;
}
