using System;
/*
Posibles clases para mi JOURNAL
Main PRogram - donde el usuario se mueve y llamamos las otras clases
Journal - Lista de entradas para presentar - contiene write disp load save
Entry - enseña solo una entrada al usuario -deveria tener su metodo display tambien
PromptGenerator - agarra una entrada random  - 
////////////////////////////////////////
Write (newentrey : entry) void - hacer una pregunta random que sugiera que escribr en el diario
Display() void - enseñar la fecha, pregunta y la respuesta dada
LOAD (file: string) - cargar de un txt
SAVE (file:string) - guardar en un txt
*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        //We create and object job and we fill it
        Job job1 = new Job();
        job1._jobTitle = "Maquina de Guerra";
        job1._company = "Ejercito Español";
        job1._yearOfStart = 1986;
        job1._yearOfEnd = 2996;
        //another one
        Job job2 = new Job();
        job2._jobTitle = "Paraca";
        job2._company = "Bripac";
        job2._yearOfStart = 1996;
        job2._yearOfEnd = 2186;
        //now we call resume to create and fill
        Resume aResume = new Resume();
        aResume._name = "Joseph Garcia";

        aResume._jobs.Add(job1);
        aResume._jobs.Add(job2);
        //now we have the name and the jobs to display
        aResume.Display();
    }
}