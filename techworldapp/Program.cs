using System;
using TechworldCL;

namespace techworldapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Feedback =");
            float avgFeedback = float.Parse(Console.ReadLine());
            Console.Write("Experience=");
            int experience = int.Parse(Console.ReadLine());
            Console.Write("Name=");
            string instructorName = Console.ReadLine();
            Console.Write("skill  =");
            string inputSkill = Console.ReadLine();
            string[] instructorSkill = inputSkill.Split(',');


            instructor inst1 = new instructor(avgFeedback, experience, instructorName, instructorSkill);
            bool elegibility = inst1.validateEligibility();
            Console.WriteLine( elegibility);
          string Technology = Console.ReadLine();
           Technology = Technology.Trim();
            inst1.CheckSkill(Technology);

        }


    }
}