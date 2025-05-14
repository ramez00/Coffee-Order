

public class Cappuccino : Espresso
{
    public override string GetDescription() => base.GetDescription() + ", steamed milk, foam";
    public override decimal GetCost() => base.GetCost() + 2.5m;
}
