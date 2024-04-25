namespace Task_2;

public class Task_2
{
    class Worker
    {
        private string name;
        private string surname;
        private int rate;
        private int days;

        public Worker(string name, string surname, int rate, int days)
        {
            this.name = name;
            this.surname = surname;
            this.rate = rate;
            this.days = days;
        }

        public string Name
        {
            get { return name; }
        }

        public string Surname
        {
            get { return surname; }
        }

        public int Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public int Days
        {
            get { return days; }
            set { days = value; }
        }

        public void GetSalary()
        {
            Console.WriteLine("Имя: " + Name);
            Console.WriteLine("Фамилия: " + Surname);
            Console.WriteLine("Дни работника: " + Days);
            Console.WriteLine("Зарплата: " + (Rate * Days));
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Имя 1:");
        string electricName = Console.ReadLine();

        Console.WriteLine("Фамилия 1:");
        string electricSurname = Console.ReadLine();

        Console.WriteLine("Ставка 1: ");
        int electricRate = int.Parse(Console.ReadLine());

        Console.WriteLine("Дни 1: ");
        int electricDays = int.Parse(Console.ReadLine());


        Console.WriteLine("Имя 2:");
        string engineerName = Console.ReadLine();

        Console.WriteLine("Фамилия 2:");
        string engineerSurname = Console.ReadLine();

        Console.WriteLine("Ставка 2: ");
        int engineerRate = int.Parse(Console.ReadLine());

        Console.WriteLine("Дни 1: ");
        int engineerDays = int.Parse(Console.ReadLine());

        Worker electric = new Worker(electricName, electricSurname, electricRate, electricDays);
        Worker engineer = new Worker(engineerName, engineerSurname, engineerRate, engineerDays);

        Console.WriteLine("Первый работник: ");
        electric.GetSalary();

        Console.WriteLine("Второй работник: ");
        engineer.GetSalary();
    }
}