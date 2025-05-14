
namespace Coffee_Order.Core.Decorator;
public class Cappuccino : CoffeeDecorator
{
    // 4. Create Concrete decorators.
    public Cappuccino(Coffee coffee) : base(coffee)
    {
    }
    public override string Describtion => base.Describtion + ", steamed milk, foam";
    public override decimal GetCost() => base.GetCost() + 0.75m;
}
