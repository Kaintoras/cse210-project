using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        //creation of the list and void initiation
        List<int> numbers = new List<int>();
        //variable
        int userNumber = -1;
        //loop to fill the list
        while (userNumber != 0){
            Console.WriteLine("Enter a number to add on the list (write 0 to finish)");
            //varaibles
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput); //to renew the valor of it every time we do the loop
            //check the number is not 0
            if(userNumber != 0){
                numbers.Add(userNumber);
            }
        }
        //once we fill the list we can work with it
        //variables
        int suma = 0;
        foreach (int number in numbers){
            suma += number;
        }
        //at the end we show the addition
        Console.WriteLine($"The addition of the numbers is: {suma}");
        //now we do the average, dividing the addition with the total number of elements and use float to decimals
        float average = ((float)suma) / numbers.Count;
        Console.WriteLine($"The average of the number on the list is: {average}");
        //now we look for the higher number
        int hNumber = numbers[0]; //we use a int that has the value of the 1 number on the list
        foreach (int number in numbers){
            if (number > hNumber){
                //we found a larger number
                hNumber = number;
            }
        }
        //at the end we show the result
        Console.WriteLine($"The largest number is: {hNumber}");
    }
}