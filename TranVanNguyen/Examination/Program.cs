using System;



namespace Examination
{
    class ScoreReport
    {
        public string Subject = "Science";
        public int Marks = 99;

        static void Main(string[] args)
        {
            Students.StudentsDetails stu = new Students.StudentsDetails();
            ScoreReport score = new ScoreReport();
            Console.WriteLine("Subject: "+score.Subject);
            Console.WriteLine("Marks:"+score.Marks);
        }
    }
}
