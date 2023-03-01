using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT

            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            // LONGEST REPS

            int startPos = 0;
            int reps = 0;
            int longest = 0;
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] == nums[i-1])
                {
                    startPos = nums[i];
                    reps++;
                    longest = reps + 1;
                }
                else
                {
                    reps = 0;
                }
            }
            Console.WriteLine($"Longest: {longest}, Start position: {startPos}\n");

            // REMOVE LONGEST REPS

            Remove(nums, startPos, longest);

        }

        private static void Remove(List<int> nums, int startPos, int longest)
        {
            for (int i = startPos; i <= longest; i++)
            {
                nums.RemoveAt(startPos);
            }
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
