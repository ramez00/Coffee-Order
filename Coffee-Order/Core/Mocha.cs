

public class Mocha : Cappuccino
{
    public override string GetDescription() => base.GetDescription() + ", chocolate";
    public override decimal GetCost() => base.GetCost() + 3.5m;
}