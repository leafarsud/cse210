using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Gerente administrativo";
        job1._company = "Sv Materiais para estofados";
        job1._startYear = 2007;
        job1._endYear = 2008;

        Job job2 = new Job();
        job2._jobTitle = "Estofador";
        job2._company = "Chic Estofados";
        job2._startYear = 2022;
        job2._endYear = 2023;

        myResume resume = new myResume();
        resume._name = "Rafael Jupy dos Santos";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();

    }
}