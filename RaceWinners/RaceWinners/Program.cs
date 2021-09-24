using System;
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

            // var num_of_students = 0;
            // var num_of_students2 = 0;
            //
            // for (int i = 0; i < data.Count; i++)
            // {
            //     for (int x = 0; x < data[i].Ranks.Count; x++)
            //     {
            //         if (num_of_students == 0)
            //         {
            //             num_of_students++;
            //         } else num_of_students2++;
            //     }
            //     
            //     if (num_of_students2 > num_of_students) // RAISE the max students that can be counted
            //     {
            //         num_of_students2 = 0;
            //     } else if (num_of_students2 < num_of_students) // This means you have to LOWER the max students that can be counted
            //     {
            //         num_of_students = num_of_students2;
            //         num_of_students2 = 0;
            //     }
            // }
            //
            // Console.WriteLine(num_of_students);
            
            
            
            
            
        }
    }
}