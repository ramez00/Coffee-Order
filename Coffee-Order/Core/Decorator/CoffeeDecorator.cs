
namespace Coffee_Order.Core.Decorator;
public abstract class CoffeeDecorator : Coffee
{
    // 3. Create coffee decorators.
    protected Coffee _coffee;
    public CoffeeDecorator(Coffee coffee)
    {
        _coffee = coffee;
    }

    public override string Describtion => _coffee.Describtion;
    public override decimal GetCost() => _coffee.GetCost();
}
