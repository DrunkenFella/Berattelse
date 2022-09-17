//Berättelse

using System;

static void Close()
{
    Console.ReadKey();
    Environment.Exit(0);
}

//namn
Console.WriteLine("(If no questions appear please press ENTER to continue)");
Console.WriteLine("(You will answer in a and b.)");
Console.ReadLine();

Console.WriteLine("A weird looking man walks upp to you, he looks at you with wondering eyes.");
Console.WriteLine("What is your name traveler?");

string name = Console.ReadLine();

if (name == "Hugo")
{
    Console.WriteLine($"Weird man - Aha you must be {name} the bitchless virgin.");
}
if (name == "Dhani")
{
    Console.WriteLine($"Weird man - Aha you are sir {name} the below average man.");
}
if (name == "Leonard")
{
    Console.WriteLine($"Weird man - Aha you are {name} the sir wiener eater.");
}
if (name == "Erik")
{
    Console.WriteLine($"Weird man - Aha you are {name} the average Metal enjoyer");
}
if (name == "William")
{
    Console.WriteLine($"Weird man - Aha you are {name} sir stinky fish.");
}
Console.WriteLine($"Weird man - {name} do you seek adventure... (a=)Yes or (b=)No?");

string yn = Console.ReadLine().ToLower();

if (yn == "a")
{
    Console.WriteLine($"Well {name} there is a dragon in the cave down the road, if you could kill it I will pay you 10 gold. Now go");
    Console.ReadLine();
    Console.WriteLine("You walk alone on a broken down road, you walk for a while and then you see it. The cave. It's massiv and all the grass around is dead.");
    Console.ReadLine();
    Console.WriteLine("You walk 10 steps more and you see a few skeleton bones, you see no boob bone so you counclude that the vicim was a man.");
    Console.ReadLine();
    Console.WriteLine("You look closer at the skeleton head and you see how perfect it's, you take a seat at a stone and wonder.");
    Console.ReadLine();
    Console.WriteLine($"Then you yell out. {name} - THIS IS RYAN REYNOLDS!!!. The dragon hears your yelling and comes out.");
    Console.ReadLine();
    Console.WriteLine("The big red dragon shows it ugly face, your body fills with rage and you luckly find a sword. You take the sword and a sheild.");
    Console.ReadLine();
    Console.WriteLine("How do you want to hit the dragon with the sword (a) or with the shield (b)");
    string sworsh = Console.ReadLine().ToLower ();
    if (sworsh == "a")
    {
        Console.WriteLine("You take out the sword and swing at the dragon who doesn't look scared, you take a few step forward and thrust towards the dragon.");
        Console.ReadLine();
        Console.WriteLine("The dragon looks annoyed and hits you with his hand. You fly 5 meters and you land on a stone. He readys another attack.");
        Console.ReadLine();
        Console.WriteLine("What do you use Sword (a) or Shield (b) ");
        string dragon= Console.ReadLine().ToLower();
        if (dragon == "a")
        {
            Console.WriteLine($"You take out your sword and the dragon blows out a fire ball on you. You become a {name} fried chicken");
            Close ();
        }
        
    }
    if (sworsh == "b")
    {
        Console.WriteLine("You take out the sheild and take cover from the Dragon, the dragon blows a fire ball at you.");
        Console.ReadLine();
        Console.WriteLine("The dragon looks out of breath, do you attack (a) or do you hide (b)");
        string attackorhide = Console.ReadLine().ToLower();
        if (attackorhide == "a")
        {
            Console.WriteLine("You attack the Dragon, you stab it in its eyes and it dies.");
            Console.ReadLine();
            Console.WriteLine("You walk back to the Weird man. With the head of Ryan Reynolds.");
            Console.ReadLine();
            Console.WriteLine("Weird man - Oh no my dearest Ryan Reynolds what have they done to you.");
            Console.ReadLine();
            Console.WriteLine("Weird man - Do you want gold or do you want to see who I'm?");
            Console.WriteLine("Do you want gold (a) or do you want to see who the Weird mans is.");
            string goldorsee = Console.ReadLine().ToLower();
            if (goldorsee == "a")
            {
                Console.WriteLine("You accept the gold and walk away, ready for a new adventure.");
                Close ();
            }
            if (goldorsee == "b")
            {
                Console.WriteLine("Weird man - If you say so.");
                Console.WriteLine("The Weird man takes of his robe to revival that he was Leonardo Dicaprio. Then he walks away to find a 20 year old girl.");
                Close ();
            } 
        }
    }
    if (sworsh == "z")
    {
        Console.WriteLine("You take out a gun that you found in your back pocketand shoot the dragon in his eyes.");
        Console.ReadLine();
        Console.WriteLine("You dig out his heart and walk back to the Weird man.");
        Console.WriteLine("Weird man - Oh thank god that you are alive. I can see that you have the heart, I didn't say that you should proof, but okay. ");
        Console.WriteLine($"Weird man - Here you have 10 gold as I promised, you are realy my hero {name} good luck on your next adventure");
        Console.ReadLine();
        Console.WriteLine("Secret ending GUN VS DRAGON");
        Close ();
    }
}
if (yn == "b")
{
    Console.WriteLine($"Weird man - You are no fun {name}, go away now sir.");

    Console.ReadLine();

    Console.WriteLine($"You go for about 20 min to get away from the weird man, then you see a girl who is about to drown. Do you save her (a) or do you walk away (b)?");
    string saveorno = Console.ReadLine().ToLower ();
    
    if (saveorno == "a")
    {
        Console.WriteLine("You swim out to save her. But you fail becuase you didnt take swiming lessons when you were a kid, so you drown.");
        Close();
    }
    if (saveorno == "b")
    {
        Console.WriteLine("You walk away like an ultra Chad, but then some robbers appear out of the bushes. They ask you to give them gold.");
        Console.WriteLine("(a = you attack them. b = you give them gold)");
        string money = Console.ReadLine().ToLower();

        if (money == "a")
        {
            Console.WriteLine($"{name} you are not so smart, they have knifes and they stab you.");
            Close();
        }
        if (money == "b")
        {
            Console.WriteLine($"{name} you are not smart, they robb you and then stab you.");
            Close();
        }
        if (money == "z")
        {
            Console.WriteLine($"You take their knife and stap yourself.");
            Close();
        }
    }
}
else
{
    Console.WriteLine("You are the stupid. Bye now.  Game over ending (secret)");
    Close();
}


Console.ReadLine();