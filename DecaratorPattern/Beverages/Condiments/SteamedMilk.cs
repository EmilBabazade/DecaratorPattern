using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecaratorPattern.Beverages.Condiments;
public class SteamedMilk(Beverage beverage) : CondimentDecorator(beverage)
{
    public override double Cost => _beverage.Cost + 0.10;

    public override string Description => "Steamed Milk " + _beverage.Description;
}
