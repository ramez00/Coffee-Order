
namespace Coffee_Order.Core.Decorator;
public class Latte : CoffeeDecorator
{
    // 4. Create Concrete decorators.
    public Latte(Coffee coffee): base(coffee)
    {
    }
    public override string Describtion => base.Describtion + ", steamed milk";

    public override decimal GetCost() => base.GetCost() + 0.50m;
}
