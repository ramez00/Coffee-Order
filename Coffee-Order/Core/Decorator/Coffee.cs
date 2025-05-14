
namespace Coffee_Order.Core.Decorator;
public abstract class Coffee
{
    // 1. Define The component 
    public abstract string Describtion { get; }
    public abstract decimal GetCost();
    public override string ToString()
        => $"You Ordered {this.GetType().Name} => {Describtion} - {GetCost():C}";
}
