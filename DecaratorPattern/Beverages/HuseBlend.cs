using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecaratorPattern.Beverages;
public class HouseBlend : Beverage
{
    public override string Description => "House Blend";

    public override double Cost => 0.89;
}