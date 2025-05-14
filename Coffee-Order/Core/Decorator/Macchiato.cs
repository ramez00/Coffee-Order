
namespace Coffee_Order.Core.Decorator;
public class Macchiato : CoffeeDecorator
{
    public Macchiato(Coffee coffee) : base(coffee)
    {
    }
    public override string Describtion => base.Describtion + ", Foam milk ";
    public override decimal GetCost() => base.GetCost() + 3.5m;
}
