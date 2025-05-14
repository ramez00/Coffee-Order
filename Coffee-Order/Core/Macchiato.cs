namespace Coffee_Order.Core;
public class Macchiato : Espresso
{
    public override string GetDescription() => base.GetDescription() + ", Foam milk ";
    public override decimal GetCost() => base.GetCost() + 3.5m;
}
