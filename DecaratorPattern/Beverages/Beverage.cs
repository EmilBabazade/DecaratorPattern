using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecaratorPattern.Beverages;
public abstract class Beverage
{
    public virtual string Description { get; }
    public virtual double Cost { get; }

    // just for ease
    public void PrintDescription() => Console.WriteLine(Description + "\t" + Cost);
}
