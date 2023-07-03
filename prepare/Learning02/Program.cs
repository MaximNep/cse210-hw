using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Courier";
        job1._company = "Yandex";
        job1._startYear = 2021;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Courier";
        job2._company = "Samokat";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Maxim Nepomnyaschy";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
