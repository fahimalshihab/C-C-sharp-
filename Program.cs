using System;

// Define an abstract Animal class that provides properties and methods common to all animals.
public abstract class Animal
{
    // Protected properties can be accessed only within the same class and its derived classes.
    protected string Name { get; set; }
    protected int Age { get; set; }

    // Constructor method to initialize a new Animal object with the provided name and age.
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Abstract method that must be implemented by any derived classes to provide a custom sound for the animal.
    public abstract void MakeSound();

    // Method that displays the name and age of the animal.
    public void DisplayInfo()
    {
        Console.WriteLine($"{Name} is {Age} years old.");
    }
}
//.................................................................................................................................

// Define a derived class Dog that inherits from the Animal class.
public class Dog : Animal
{
    // Constructor method to initialize a new Dog object with the provided name and age.
    public Dog(string name, int age) : base(name, age)
    {
    }

    // Override the MakeSound method to provide a custom bark sound for the dog.
    public override void MakeSound()
    {
        Console.WriteLine("Bark!");
    }
}
//...................................................................................................................................


// Define a derived class Cat that inherits from the Animal class.
public class Cat : Animal
{
    // Constructor method to initialize a new Cat object with the provided name and age.
    public Cat(string name, int age) : base(name, age)
    {
    }

    // Override the MakeSound method to provide a custom meow sound for the cat.
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}
//...................................................................................................................................


// Define a program class with a Main method that creates instances of Dog and Cat objects and calls their methods.
class Program
{
    static void Main(string[] args)
    {
       /* // Create a new Dog object with the name "Buddy" and age 3.
        Dog myDog = new Dog("Buddy", 3);
        // Call the MakeSound method for the Dog object.
        myDog.MakeSound();
        // Call the DisplayInfo method for the Dog object.
        myDog.DisplayInfo();

        // Create a new Cat object with the name "Whiskers" and age 2.
        Cat myCat = new Cat("Whiskers", 2);
        // Call the MakeSound method for the Cat object.
        myCat.MakeSound();
        // Call the DisplayInfo method for the Cat object.
        myCat.DisplayInfo();*/
//.................................................................................................................................

        // Declare an array of Animal objects that can hold instances of any Animal or derived class.
        Animal[] animals = new Animal[4];
        // Initialize the first element of the array to a new Dog object.
        animals[0] = new Dog("Rex", 5);
        // Initialize the second element of the array to a new Cat object.
        animals[1] = new Cat("Fluffy", 1);
        animals[2] = new Dog("Max", 2); // add another dog
        animals[3] = new Dog("Charlie", 4); // add another dog

       

        // Loop through each element in the animals array and call its MakeSound and DisplayInfo methods.
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
            animal.DisplayInfo();
        }
    }
}
