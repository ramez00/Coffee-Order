

namespace Coffee_Order.Core.Decorator;
public class Espresso : Coffee
{
    // 2. Define Concrete Component
    public override string Describtion => "Espresso";
    public override decimal GetCost() => 3.5m;
}
