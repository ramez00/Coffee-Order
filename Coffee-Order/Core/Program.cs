

using Coffee_Order.Core.Decorator;

Console.WriteLine("Welcome to the Coffee Order System!");
Console.WriteLine("Please select your coffee order:");
Console.WriteLine("1. Espresso");
Console.WriteLine("2. Americano");
Console.WriteLine("3. Latte");
Console.WriteLine("4. Mocha");
Console.WriteLine("5. Cappuccino");
Console.WriteLine("6. Macchiato");
Console.WriteLine("7. Mixed Latte with Americano");

int choice = int.Parse(Console.ReadLine()!);

Coffee order = new Espresso();
switch (choice)
{
    case 1:
       order = order;
        break;
    case 2:
        order = new Americano(order);
        break;
    case 3:
        order = new Latte(order);
        break;
    case 4:
        order = new Mocha(order);
        break;
    case 5:
        order = new Cappuccino(order);
        break;
    case 6:
        order = new Macchiato(order);
        break;
    case 7:
        // Mixed Latte with Americano as Wrapper 
        order = new Latte(order);
        order = new Americano(order);
        order = new Mocha(order);
        break;
    default:
        Console.WriteLine("Invalid selection. Please try again.");
        break;
}

Loading();

Console.WriteLine(order);


void Loading()
{
    Console.Write("Loading...");
    for (int i = 0; i < 5; i++)
    {
        Console.Write(".");
        Thread.Sleep(500);
    }
    Console.WriteLine();
}