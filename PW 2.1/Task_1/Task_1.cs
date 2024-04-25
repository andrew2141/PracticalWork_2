namespace Task_1;

public class Task_1
{
    static void Main(string[] args)
    {
        string J = "ab";
        string S = "aabbccd";

        int count = 0;

        for (int i = 0; i < J.Length; ++i)
        {
            for (int j = 0; j < S.Length; ++j)
            {
                if (J[i] == S[j])
                {
                    ++count;
                }
            }
        }
        Console.WriteLine(count);
    }
}