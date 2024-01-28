using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        //Parte 1
        //Console.WriteLine("Choose a number:");
        //we get and transform the string to int
        //int numero = int.Parse(Console.ReadLine());

        //Parte 3
        //include random
        Random randomNumber = new Random();
        // creation of the random number between 1-100
        int Rnumber = randomNumber.Next(1,100);
        //variable to compare
        int userNumber = 0;
        // varaible to counter
        int counter = 0;
        //varaible to restart the game
        bool replay = false;
        //loop to create a game
        while (userNumber != Rnumber){
            Console.WriteLine("Try to guess the number between 1 and 100");
            userNumber = int.Parse(Console.ReadLine());
            //nested if to compare and give hint
            if (Rnumber > userNumber){
                Console.WriteLine("The number has to be higher");
            }
            else if (Rnumber < userNumber){
                Console.WriteLine("The number is lower");
            }
            else{
                Console.WriteLine("You win!");
            }
            counter = counter+1;
        }
        Console.WriteLine($"You tried {counter} times to guess the number");
    }
}