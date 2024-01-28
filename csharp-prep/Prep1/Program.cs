using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine("What is your first name?");
        string fname = Console.ReadLine();
        //writeline = print read = input
        Console.WriteLine("What is your last name?");
        string lname = Console.ReadLine();
        // now we have stored the name and last name in the variables
        Console.WriteLine($"Your name is {lname}, {fname} {lname}. And I don't like martinis");
    }
}