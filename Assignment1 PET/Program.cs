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
        //assigning the values
        Type = type;
        Name = name;
        Hunger = 5;                                       
        Happiness = 5;
        Health = 5;
    }

    public void Feed()
    {  //certain condition for Feed
        Console.WriteLine($"{Name} is being fed.");
        Hunger = Math.Max(0, Hunger - 2);                  
        Health = Math.Min(10, Health + 1);
        DisplayStatus();
    }

    public void Play()
    {
        Console.WriteLine($"{Name} is playing.");
        Happiness = Math.Min(10, Happiness + 2);           //certain condition for Play
        Hunger = Math.Min(10, Hunger + 1);
        DisplayStatus();
    }
    public void Rest()
    {
        Console.WriteLine($"{Name} is resting.");
        Health = Math.Min(10, Health + 2);                  //certain condition for Rest
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
        Console.WriteLine("Welcome to the Virtual Pet Simulator!");
        Console.Write("Enter the type of your pet (e.g., cat, dog, rabbit): ");
        string petType = Console.ReadLine();

        Console.Write("Enter your pet's name: ");
        string petName = Console.ReadLine();

        VirtualPet pet = new VirtualPet(petType, petName,5,5);

        Console.WriteLine($"Welcome, {pet.Name} the {pet.Type}!");

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Feed the pet");
            Console.WriteLine("2. Play with the pet");
            Console.WriteLine("3. Let the pet rest");
            Console.WriteLine("4. Check pet's status");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    pet.Feed();
                    break;
                case 2:
                    pet.Play();
                    break;
                case 3:
                    pet.Rest();
                    break;
                case 4:
                    pet.DisplayStatus();
                    break;
                case 5:
                    exit = true;
                    Console.WriteLine("Exiting the Virtual Pet Simulator. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;

            }

        }
    }

}