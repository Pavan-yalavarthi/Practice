using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    class CricketTeam
    {
        public void Pointscalculation(int no_of_matches)
        {
            int total = 0;
            Console.WriteLine($"Enter the scores for {no_of_matches} matches:");

            for (int i = 0; i < no_of_matches; i++)
            {
                Console.Write($"Match {i + 1} Score: ");
                int score = int.Parse(Console.ReadLine());
                total += score;
            }

            double average = total / no_of_matches;
            Console.WriteLine($"Total Matches Played: {no_of_matches}");
            Console.WriteLine($"Total Score: {total}");
            Console.WriteLine($"Average Score: {average}");
           
        }

        static void Main()
        {
            CricketTeam team = new CricketTeam();
            Console.Write("Enter the number of matches played: ");
            int matches = int.Parse(Console.ReadLine());
            team.Pointscalculation(matches);
            Console.Read();
        }
    }
}

