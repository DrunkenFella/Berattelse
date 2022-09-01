//Berättelse

//namn
Console.WriteLine("A weird looking man walks upp to you, he looks at you with wondering eyes.");
Console.WriteLine("What is your name traveler?");

string name = Console.ReadLine();


Console.WriteLine($"Hello {name}, do you seek adventure... Yes or No?");

string yn = Console.ReadLine();

if (yn.ToLower() == "yes")
{
    Console.WriteLine($"Well {name} there is a dragon in the cave down the road, if you could kill it I will pay you 10 gold.");
}
if (yn.ToLower() == "no")
{
    Console.WriteLine($"You are no fun {name}, go away now sir.");

    Console.ReadLine();
    
    Console.WriteLine("You go for about 20 min to get away from the weird man, then you see a girl who look like she is about to drown. Do you save her or do you walk away?");
    string saveorno = Console.ReadLine();
    if (saveorno == save her)
    {
        Console.WriteLine("You swim out to save her. But you fail becuase you didnt take swiming lessons when you were a kid, so you drown.");
    }
    if (saveorno == walk away)
    {
        Console.WriteLine("You walk away like an ultra Chad, but then your conscience gets the better of you and you decide to kill youself. But how do you want to kill yourself, gun or knife?");
        string GunOrKnife = Console.ReadLine();
        if (GunOrKnife == Gun)
        {
            Console.WriteLine("You take out your rocket launcher");
        }
        
    }
}
else 
{
    Console.WriteLine("I dont want you you have the stupid, .");
}


Console.ReadLine();