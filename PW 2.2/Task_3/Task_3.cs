namespace Task_3;

public class Task_3
{
    class Number
    {
        private int firstNumber;
        private int secondNumber;

        public void PrintNumbers()
        {
            Console.WriteLine($"Первое число: {firstNumber}");
            Console.WriteLine($"Второе число: {secondNumber}");
        }

        public void SetNumbers(int first, int second)
        {
            firstNumber = first;
            secondNumber = second;
        }

        public void ChangeNumbers(int first, int second)
        {
            firstNumber = first;
            secondNumber = second;
        }

        public int GetSum()
        {
            return firstNumber + secondNumber;
        }
        
        public int GetMaxValue()
        {
            return Math.Max(firstNumber, secondNumber);
        }
    }
    
    static void Main(string[] args)
    {
        Number numbers = new Number();
        numbers.SetNumbers(8, 1);
        
        numbers.PrintNumbers();

        Console.WriteLine($"Сумма чисел: {numbers.GetSum()}");
        Console.WriteLine($"Наибольшее число: {numbers.GetMaxValue()}");
        
        numbers.ChangeNumbers(10, 5);
        
        numbers.PrintNumbers();
        
        Console.WriteLine($"Сумма чисел: {numbers.GetSum()}");
        Console.WriteLine($"Наибольшее число: {numbers.GetMaxValue()}");
    }
}