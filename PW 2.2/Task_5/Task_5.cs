namespace Task_5;

public class Task_5
{
    class classWithTwoProperties
    {
        private int firstProperty;
        private int secondProperty;
        
        public classWithTwoProperties()
        {
            
        }
        
        public classWithTwoProperties(int FirstProperty, int SecondProperty)
        {
            firstProperty = FirstProperty;
            secondProperty = SecondProperty;
        }

        ~classWithTwoProperties()
        {
            Console.WriteLine("Объект удалён.");
        }

        public void DisplayProperties()
        {
            Console.WriteLine($"Первое свойство: {firstProperty}");
            Console.WriteLine($"Второе свойство: {secondProperty}");
        }

    }
    static void Main(string[] args)
    {
        Console.WriteLine("1");
        
        classWithTwoProperties MyClass_1 = new classWithTwoProperties();
        MyClass_1.DisplayProperties();
        
        Console.WriteLine("2");
        
        classWithTwoProperties MyClass_2 = new classWithTwoProperties(10, 11);
        MyClass_2.DisplayProperties();
    }
}