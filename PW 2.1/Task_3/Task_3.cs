namespace Task_3;

public class Task_3
{
    static void Main(string[] args)
    {
        int[] nums = new[] { 2, 3, 2, 1, 4, 5, 8 };
        bool isRepeat = false;

        for (int i = 0; i < nums.Length; ++i)
        {
            for (int j = 0; j < nums.Length; ++j)
            {
                if (nums[i] == nums[j])             
                {
                    isRepeat = true;
                    break;
                }
            }          
        }
        Console.WriteLine(isRepeat);
    }
}