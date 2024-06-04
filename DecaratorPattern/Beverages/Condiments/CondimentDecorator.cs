using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecaratorPattern.Beverages.Condiments;
public abstract class CondimentDecorator(Beverage beverage) : Beverage
{
    protected readonly Beverage _beverage = beverage;
}
