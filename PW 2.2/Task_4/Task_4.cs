namespace Task_4;

public class Task_4
{
    class Counter
    {
        private int value;

        public Counter()
        {
            value = 0;
        }

        public Counter(int initialValue)
        {
            value = initialValue;
        }

        public void Increment()
        {
            value++;
        }

        public void Decrement()
        {
            value--;
        }

        public int GetValue()
        {
            return value;
        }
    }
    
    static void Main(string[] args)
    {
        Counter counter1 = new Counter(5);
        Counter counter2 = new Counter();
        
        Console.WriteLine($"Значение counter1: {counter1.GetValue()}");
        Console.WriteLine($"Значение counter2: {counter2.GetValue()}");
        
        counter1.Increment();
        counter2.Decrement();
        
        Console.WriteLine($"Значение counter1: {counter1.GetValue()}");
        Console.WriteLine($"Значение counter2: {counter2.GetValue()}");
    }
}