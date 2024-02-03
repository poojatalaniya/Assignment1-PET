// My name is Pooja Talaniya, email- Ptalaniya4569@conestogac.on.ca - student ID- 8904569
//Assignment 1 - Virtual PET Simulator Project
//Starting the code for the PET store
using System;

class VirtualPet            //creating a class for defining datatypes and variables
{
    public string Type { get; set; }
    public string Name { get; set; }
    public int Hunger { get; set; }
    public int Happiness { get; set; }
    public int Health { get; set; }

    public VirtualPet(string type, string name, int hunger, int health)
    {
        Type = type;
        Name = name;
        Hunger = 5;
        Happiness = 5;
        Health = 5;
    }

    public void Feed()
    {
        Console.WriteLine($"{Name} is being fed.");
        Hunger = Math.Max(0, Hunger - 2);
        Health = Math.Min(10, Health + 1);
        DisplayStatus();
    }

    public void Play()
    {
        Console.WriteLine($"Name is playing.");
        Happiness = Math.Min(10, Happiness + 2);
        Hunger = Math.Min(10, Hunger + 1);
        DisplayStatus();
    }
    public void Rest()
    {
        Console.WriteLine($"{Name} is resting.");
        Health = Math.Min(10, Health + 2);
        Happiness = Math.Max(0, Happiness - 1);
        DisplayStatus();
    }
    public void DisplayStatus()
    {
        Console.WriteLine($"Status of {Name} ({Type}): Hunger - {Hunger}, Happiness - {Happiness}, Health - {Health}");
        CheckStatus();
    }

    public void CheckStatus()
    {
        if (Hunger <= 2 || Happiness <= 2 || Health <= 2)
        {
            Console.WriteLine("Warning: Pet is not feeling well. Please take care!");
        }
        else if (Hunger >= 8 || Happiness >= 8 || Health >= 8)
        {
            Console.WriteLine("Warning: Pet is extremely happy or full. Be cautious!");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Virtual Pet Simulator - Pet Creation\n");

        Console.Write("Enter the type of your Pet (e.g.,cat,dog,bunny): ");
        string petType = Console.ReadLine();

        Console.Write("Enter your pet's name: ");
        string petName = Console.ReadLine();

        VirtualPet pet = new VirtualPet(petType, petName);

        pet.DisplayWelcomeMessage();
    }
}