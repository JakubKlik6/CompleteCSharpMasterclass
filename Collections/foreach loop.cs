using MembersC;
using System;
using System.ComponentModel;

namespace completeMasterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
                Console.WriteLine(nums[i]);
            }

            int counter = 0;
            //Foreach loop
            foreach (int k in nums)
            {
                Console.WriteLine("Element {0} = {1}",counter,k);
                counter++;
            }

            //String array
            string[] friends = new string[] {"Jasiu","Boston","Maciek","Bartek","Michał"};

            foreach (string friend in friends)
            {
                Console.WriteLine("Hello {0}",friend);
            }

            Console.Read();
        }
    }
}
