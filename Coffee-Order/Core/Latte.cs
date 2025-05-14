

public class Latte : Espresso
{
    public override string GetDescription() => base.GetDescription() + ", steamed milk ";
    public override decimal GetCost() => base.GetCost() + 1.5m;
}
