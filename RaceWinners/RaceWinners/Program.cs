using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RaceWinners
{
    class Program
    {
        static async Task Main(string[] args)
        {
            DataService ds = new DataService();

            // Asynchronously retrieve the group (class) data
            var data = await ds.GetGroupRanksAsync();

            var array = new List<int>(data.Count);
            var ranks = new List<int>(data.Count);
            var final_scores = new List<int>(data.Count);

            for (int i = 0; i < data.Count; i++)
            {
                var a = 0;
                for (int x = 0; x < data[i].Ranks.Count; x++)
                {
                    a++;
                }

                array.Add(a);
            }

            var max_students = array.Min(); // Max students that every class has in common

            for (int i = 0; i < data.Count; i++)
            {
                var score = 0;

                for (int x = 0; x < max_students; x++) // Going through each score to add
                {
                    score += data[i].Ranks[x];
                }

                score = score / max_students;

                final_scores.Add(score);
            }

            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine("Final Score: " + data[i].Name + " - " + final_scores[i]);
            }
        }
    }
}