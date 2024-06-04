namespace DecaratorPattern.Beverages.Condiments;

public class Soy(Beverage beverage) : CondimentDecorator(beverage)
{
    public override double Cost => _beverage.Cost + 0.15;

    public override string Description => "Soy " + _beverage.Description;
}
