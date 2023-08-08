namespace TechworldCL
{
    public class instructor
    {
        public float avgFeedback;
        public int experience;
        public string? instructorName;
        public string[] instructorSkill;

        public instructor(float avgFeedback, int experience, string instructorName, string[] instructorSkill)
        {
            this.avgFeedback = avgFeedback;
            this.experience = experience < 0 ? 1 : experience;
            this.instructorName = instructorName;
            this.instructorSkill = instructorSkill;
        }

        public bool validateEligibility()
        {
            if (experience > 3 && avgFeedback >= 4.5)
            {
                return true;

            }
            else if (experience < 3 && avgFeedback <= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CheckSkill(string Technology)
        {
            Console.Write("Technology =");
            Technology = Console.ReadLine();
            foreach (string skill in instructorSkill)
            {
                if (Array.Exists(instructorSkill, skill => Technology.Equals(skill.Trim(), StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("you have skill is validated");
                    return;
                }
            }

                Console.WriteLine("your skill is not validated");
                

            

        }
    }
}
