using System;

namespace Leetcode_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {-1, -2, -3, -4, -5};
            int mytarget = -8;

            int[] result = TargetSum(myArray, mytarget);
            foreach (var index in result)
            {
                Console.Write($"{index} ");
            }
            

            
        }

        public static int[] TargetSum(int[] nums, int target) // Accepted into Leetcode
        {
            for (int k = 0; k < nums.Length; k++)
            {
                for (int j = k + 1; j < nums.Length; j++)
                    if (nums[k] + nums[j] == target)
                    {
                        return new int[] { k, j };
                    }

            }
            return null;
        }




        public static int[] TargetSumBetter(int[] nums, int target) // Work in progress
        {
            int leftBound = 0;
            int rightBound = nums.Length - 1;
            int sum;
            if (target >= 0)
            {
                if (nums.Length <= 3)
                {
                    for (int k = 0; k < nums.Length; k++)
                    {
                        for (int j = k + 1; j < nums.Length; j++)
                            if (nums[k] + nums[j] == target)
                            {
                                return new int[] { k, j };
                            }

                    }
                }
                else
                {
                    while (leftBound < rightBound)
                    {
                        sum = nums[leftBound] + nums[rightBound];
                        if (sum == target)
                        {
                            return new int[] { leftBound, rightBound };

                        }
                        if (sum > target)
                        {

                            rightBound--;


                        }
                        else
                            leftBound++;


                    }
                }
            }
            else
            {
                if (nums.Length <= 3)
                {
                    for (int k = 0; k < nums.Length; k++)
                    {
                        for (int j = k + 1; j < nums.Length; j++)
                            if (nums[k] + nums[j] == target)
                            {
                                return new int[] { k, j };
                            }

                    }
                }
                else
                {
                    while (leftBound < rightBound)
                    {
                        sum = nums[leftBound] + nums[rightBound];
                        if (sum == target)
                        {
                            return new int[] { leftBound, rightBound };

                        }
                        if (sum > target)
                        {

                            leftBound++;


                        }
                        else
                            rightBound--;


                    }
                }
            }

            
            return new int[] { };
            

        }

    }
}
