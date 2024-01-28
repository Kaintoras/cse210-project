using System;

class Program
{
    //in the main we only call the functions and we define the functions below the main (if you wish)
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        //show welcome and later ask for info
        ShowWelcome();
        //variables to fill with functions
        string userName = GetUserName();
        int userNumber = GetUserNumber();
        //we work with the data
        int numberSquare = GetSquare(userNumber);
        //show results
        ShowResults(userName, numberSquare);
    }
    //functions to work with in main
    //Is void does not return
    static void ShowWelcome(){
        Console.WriteLine("Welcome Welcome Welcome!!");
    }
    //we need to return the result of the function that is going to be a string
    static string GetUserName(){
        Console.WriteLine("Write your name please");
        string name = Console.ReadLine();
        return name;
    }
    //we need to return the result of the function that is going to be a integer
    static int GetUserNumber(){
        Console.WriteLine("Please write a number");
        int number = int.Parse(Console.ReadLine());//we take the number and make it a int
        return number;
    }
    // it gest a integer called number just as a local variable that later dies and retunrs it squared
    static int GetSquare(int number){
        int square = number * number;
        return square;
    }
    //it recieves 2 elements and works with it, does not return
    static void ShowResults(string name, int square){
        Console.WriteLine($"{name}, the square number is {square}");
    }

}