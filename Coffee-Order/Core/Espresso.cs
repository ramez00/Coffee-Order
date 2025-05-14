

public class Espresso
{
    public virtual string GetDescription() => "Espresso";
    public virtual decimal GetCost() => 3.5m;
    public override string ToString() => $"You Ordered {this.GetType().Name} => {GetDescription()} - {GetCost():C}"; 
}
