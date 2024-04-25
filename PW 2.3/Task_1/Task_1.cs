namespace Task_1;

public class Task_1
{
    class Worker
    {
        private string name;
        private string surname;
        private int rate;
        private int days;

        public Worker(string Name, string Surname, int Rate, int Days)
        {
            name = Name;
            surname = Surname;
            rate = Rate;
            days = Days;
        }

        public void GetSalary()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Фамилия: " + surname);
            Console.WriteLine("Ставка: " + rate);
            Console.WriteLine("Рабочие дни:" + days);
            Console.WriteLine("Зарплата: " + (rate * days));
        }
    }
    
    static void Main(string[] args)
    {
        Worker electric = new Worker("Алексей", "Бичевин", 100, 30);
        Worker engineer = new Worker("Максим", "Нагорнов", 90, 50);

        Console.WriteLine("Первый работник: ");
        electric.GetSalary();
        
        Console.WriteLine("Первый работник: ");
        electric.GetSalary();
    }
}