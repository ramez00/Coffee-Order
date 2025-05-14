

namespace Coffee_Order.Core.Decorator;
public class Mocha : Cappuccino
{
    public Mocha(Coffee coffee) : base(coffee)
    {
    }
    public override string Describtion => base.Describtion + ", chocolate ";
    public override decimal GetCost() => base.GetCost() + 2.75m;
}
