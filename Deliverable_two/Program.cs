namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            double buffetPrice = 0;
            double drinkPrice = 0;
            int coffeeCount = 0;
            int waterCount = 0;
            while (true)
            {
                Console.WriteLine($"Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or lower.");
                var partySize = Console.ReadLine();
                if (!int.TryParse(partySize, out var party))
                {
                    continue; // I put a continue here, I know we are supposed to "assume valid inputs" so I don't really see the harm in it either way.
                }
                if (party == 0 || party > 6)
                {
                    Console.WriteLine("Oh sorry, can only seat parties up to 6. Have a nice day.");
                    break;
                }
                Console.WriteLine($"A table for {party}! Please follow me and take a seat. Let's get everyone started with some drinks. We've got water or coffee.");
                buffetPrice += 9.99 * party;
                for (int i = 1; i <= party; i++)
                {
                    Console.WriteLine($"Alright, person number {i}, water of coffee?");
                    var drink = Console.ReadLine();
                    if (drink.ToLower() == "coffee")
                    {
                        coffeeCount++;
                        Console.WriteLine("Coffee, okay!");
                        drinkPrice += 2.00;
                    }
                    else if (drink.ToLower() == "water")
                    {
                        waterCount++;
                        Console.WriteLine("Water, good choice!");
                    }
                    else
                    {
                        Console.WriteLine("We don't have that. No drink for you!");
                    }
                }
                break;
            }
            if (buffetPrice > 0)
            {
                var coffees = coffeeCount > 1 ? "coffees" : "coffee";
                var waters = waterCount > 1 ? "waters" : "water";
                Console.WriteLine($"Okay, so that's {coffeeCount} {coffees} and {waterCount} {waters}. I'll be right back. Feel free to grab your food!");
                Console.WriteLine($"Here's your bill! Total price: ${buffetPrice + drinkPrice:0.00}");
            }

        }
    }
}