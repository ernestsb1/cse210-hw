using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        Job Job1 = new Job();
        Job1._jobTitle = "Software Engineer";
        Job1._company = "Ernest Intercontinental";
        Job1._startYear = 2019;
        Job1._endYear = 2022;


        Job Job2 = new Job();
        Job2._jobTitle = "Excutive Director";
        Job2._company = "Ndi Assam Foundation";
        Job2._startYear = 2022;
        Job2._endYear = 2024;


       

         Resume myResume = new Resume();
         myResume._name = "Ernest Nyore";
         myResume._jobs.Add(Job1);
        myResume._jobs.Add(Job2);

    
         myResume.Display();
 }

}
