namespace _02_Pokemon_Dont_GoByMe
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Pokemon_Dont_GoByMe
    {
        static void Main()
        {

            List<int> nums = Console.ReadLine().Split(' ')
                   .Select(int.Parse)
                   .ToList();

            int index = 0;
            int current = 0;
            int sum = 0;


            while (nums.Count > 0)
            {
                index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    current = nums[0];
                    nums[0] = nums[nums.Count - 1];
                }

                else if (index > nums.Count - 1)
                {
                    current = nums[nums.Count - 1];
                    nums[nums.Count - 1] = nums[0];
                }

                else
                {
                    current = nums[index];
                    nums.RemoveAt(index);
                }

                sum += current;

                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] <= current)
                    {
                        nums[i] += current;
                    }
                    else if (nums[i] > current)
                    {
                        nums[i] -= current;

                    }
                }


            }

            Console.WriteLine(sum);



        }
    }
}
