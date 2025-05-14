
namespace Coffee_Order.Core.Decorator;
public class Americano : CoffeeDecorator
{
    // 4. Create Concrete decorators.
    public Americano(Coffee coffee) : base(coffee)
    {
    }
    public override string Describtion => base.Describtion + ", hot water";
    public override decimal GetCost() => base.GetCost() + 0.50m;
}
