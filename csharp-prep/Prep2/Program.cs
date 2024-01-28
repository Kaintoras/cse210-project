using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade calification?");
        string calification = Console.ReadLine();
        //now we change the string to integer
        int grade = int.Parse(calification);
        //now we create an empty variable for the letter we are going to show
        string letra = "";
        //if anidados -- nested if?
        if (grade >= 90){
            letra = "A";
        }
        else if (grade >= 80){
            letra = "B";
        }
        else if (grade >= 70){
            letra = "C";
        }
        else if (grade >= 60){
            letra = "D";
        }
        else {
            letra = "F";
        }
        //now we print the grade
        Console.WriteLine($"Your grade is: {letra}");
        //now we show if pass
        if (grade >= 70){
            Console.WriteLine("You passed, congratulations");
        }
        else{
            Console.WriteLine("Keep trying, no surrender");
        }
        //end of program
    }
}