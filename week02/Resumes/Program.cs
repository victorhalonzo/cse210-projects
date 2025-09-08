using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "NASA";
        job1._startYear = 2032;
        job1._endYear = 2037;
        //Console.WriteLine(job1._company);

        Job job2 = new Job();
        job2._jobTitle = "Sportscaster";
        job2._company = "Radio Caravana";
        job2._startYear = 2037;
        job2._endYear = 2045;
        //Console.WriteLine(job2._company);

        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();

        Resume resume1 = new Resume();
        resume1._name = "Victor Alonzo";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        //Console.WriteLine(resume1._jobs[0]._jobTitle);

        resume1.Display();


    }
}