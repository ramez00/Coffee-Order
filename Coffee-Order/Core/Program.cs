

using Coffee_Order.Core;

Console.WriteLine("Welcome to the Coffee Order System!");
Console.WriteLine("Please select your coffee order:");
Console.WriteLine("1. Espresso");
Console.WriteLine("2. Americano");
Console.WriteLine("3. Latte");
Console.WriteLine("4. Mocha");
Console.WriteLine("5. Cappuccino");
Console.WriteLine("6. Macchiato");

int choice = int.Parse(Console.ReadLine()!);

var order = new object();
switch (choice)
{
    case 1:
       order = new Espresso();
        break;
    case 2:
        order = new Americano();
        break;
    case 3:
        order = new Latte();
        break;
    case 4:
        order = new Mocha();
        break;
    case 5:
        order = new Cappuccino();
        break;
    case 6:
        order = new Macchiato();
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