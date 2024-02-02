using System;
public class Job{
    public string _jobTitle;
    public string _company;
    public int _yearOfStart;
    public int _yearOfEnd;

    public void Display(){
        Console.WriteLine($"{_jobTitle} in {_company} from {_yearOfStart} to {_yearOfEnd}");
    }    
}