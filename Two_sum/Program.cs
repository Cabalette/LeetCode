namespace Two_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[] { 3,2,4 }; int target=6;
            
            Solution.TwoSum(ints, target);
            Console.WriteLine();
        }
        static public class Solution
        {
            static public int[] TwoSum(int[] nums, int target)
            {
                int[] result = new int[2];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = i + 1; j < nums.Length ; j++)
                    {
                        if( nums[i] + nums[j] == target)
                        {
                            result[0] = i; result[1] = j;return result;
                        } continue;
                    }
                }return result;

            }
            /*
             * Input: nums = [2,7,11,15], target = 9
               Output: [0,1]
               Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
            */
        }
    }

}