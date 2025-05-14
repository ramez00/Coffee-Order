

public class Americano : Espresso
{
    public override string GetDescription() => base.GetDescription() + ", hot water";
    public override decimal GetCost() => base.GetCost() + 0.5m;
}
