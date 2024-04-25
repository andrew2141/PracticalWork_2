namespace Task_2;

public class Task_2
{
    class Train
    {
        public string ItemNameDestination { get; set; }
        public int TrainNumber { get; set; }
        public DateTime DepartureTime { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Пункт назначения: { ItemNameDestination }");
            Console.WriteLine($"Номер поезда: { TrainNumber }");
            Console.WriteLine($"Время отправления: { DepartureTime }");
        }
    }
    
    static void Main(string[] args)
    {
        Train train_1 = new Train
        {
            ItemNameDestination = "Томск",
            TrainNumber = 11,
            DepartureTime = new DateTime(2024, 04, 16, 22, 30, 00)
        };
        
        Train train_2 = new Train
        {
            ItemNameDestination = "Кемерово",
            TrainNumber = 12,
            DepartureTime = new DateTime(2024, 03, 15, 23, 40, 00)
        };

        Console.WriteLine("Номер поезда: ");
        int trainNumber = int.Parse(Console.ReadLine());

        if (trainNumber == train_1.TrainNumber)
        {
            train_1.PrintInfo();
        }
        else if (trainNumber == train_2.TrainNumber)
        {
            train_2.PrintInfo();
        }
        else
        {
            Console.WriteLine("Некорректный номер");
        }
    }
}