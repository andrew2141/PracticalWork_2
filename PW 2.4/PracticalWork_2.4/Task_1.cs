namespace PracticalWork_2._4;

public class Task_1
{
    static void Main(string[] args)
    {
        var romanNumerals = new Dictionary<char, int>()
        {
            { 'I' ,     1  },
            { 'V' ,     5  },
            { 'X' ,    10  },
            { 'L' ,    50  },
            { 'C' ,   100  },
            { 'D',    500  },
            { 'M',   1000  }
        };
        
        Console.WriteLine("Римское число: ");
        string line = Console.ReadLine();

        int result = 0;
        
        for (int i = 0; i < line.Length; ++i)
        {
            if (i + 1 < line.Length && romanNumerals[line[i]] < romanNumerals[line[i + 1]])
            {
                result -= romanNumerals[line[i]];
            }
            else
            {
                result += romanNumerals[line[i]];
            }
        }

        Console.WriteLine("Исходная строка: " + line);
        Console.WriteLine("Результат: " + result);

    }
}