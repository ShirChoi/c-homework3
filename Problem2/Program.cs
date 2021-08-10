using System;

namespace Problem2 {
    class Program {
        static void Main(string[] args) {
            int[] nums = new int[4];

            for(int i = 0; i < 4; i++)
                nums[i] = ReadInt($"number {i + 1}");
                

            if(nums[0] < nums[1] && nums[1] < nums[2] && nums[2] < nums[3]) {
                System.Console.WriteLine("Числа расположены по возрастанию");
            } else {
                Array.Sort(nums);

                int result = nums[0] == nums[3] ? (int)Math.Pow(nums[0], 4) : nums[0];

                System.Console.WriteLine(result);
            }
        }

        static int ReadInt(string name) {
            System.Console.Write($"{name} = ");
            return int.Parse(Console.ReadLine());
        }
    }
}
