namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }
        public static List<int> RemoveHigherValues(List<int> nums, int value)
        {
            foreach (int num in nums)
            {
                if (num > value)
                {
                    nums.Remove(num);
                }
            }
            return nums;
        }
    }
}
