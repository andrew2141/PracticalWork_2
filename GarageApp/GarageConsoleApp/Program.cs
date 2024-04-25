using System;
using GarageConsoleApp;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Просмотр и добавление типов машин");
            Console.WriteLine("2. Просмотр и добавление водителей и их прав");
            Console.WriteLine("3. Просмотр и добавление машин");
            Console.WriteLine("4. Просмотр и добавление маршрутов");
            Console.WriteLine("5. Просмотр и добавление рейсов");
            Console.WriteLine("6. Добавление категории прав");
            Console.WriteLine("6. Просмотр категории прав");
            Console.WriteLine("0. Выход");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DatabaseRequests.GetTypeCarQuery();
                    Console.Write("Введите название нового типа машины: ");
                    string newTypeCarName = Console.ReadLine();
                    DatabaseRequests.AddTypeCarQuery(newTypeCarName);
                    break;

                case 2:
                    DatabaseRequests.GetDriverQuery();
                    Console.Write("Введите имя нового водителя: ");
                    string newDriverFirstName = Console.ReadLine();
                    Console.Write("Введите фамилию нового водителя: ");
                    string newDriverLastName = Console.ReadLine();
                    Console.Write("Введите дату рождения нового водителя (ГГГГ.ММ.ДД): ");
                    DateTime newDriverBirthdate = DateTime.Parse(Console.ReadLine());
                    DatabaseRequests.AddDriverQuery(newDriverFirstName, newDriverLastName, newDriverBirthdate);
                    break;

                case 3:
                    DatabaseRequests.GetCarQuery();
                    Console.Write("Введите название новой машины: ");
                    string newCarName = Console.ReadLine();
                    Console.Write("Введите номер новой машины: ");
                    string newCarStateNumber = Console.ReadLine();
                    Console.Write("Введите количество пассажиров новой машины: ");
                    int newCarNumPassengers = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите id типа машины: ");
                    int newCarIdTypeCar = Convert.ToInt32(Console.ReadLine());
                    DatabaseRequests.AddCarQuery(newCarIdTypeCar, newCarName, newCarStateNumber, newCarNumPassengers);
                    break;

                case 4:
                    DatabaseRequests.GetItineraryQuery();
                    Console.Write("Введите название нового маршрута: ");
                    string newItineraryName = Console.ReadLine();
                    DatabaseRequests.AddItineraryQuery(newItineraryName);
                    break;

                case 5:
                    DatabaseRequests.GetRouteQuery();
                    Console.Write("Введите id водителя: ");
                    int newRouteDriverId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите id машины: ");
                    int newRouteCarId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите id маршрута: ");
                    int newRouteItineraryId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите количество пассажиров: ");
                    int newRouteNumPassengers = Convert.ToInt32(Console.ReadLine());
                    DatabaseRequests.AddRouteQuery(newRouteDriverId, newRouteCarId, newRouteItineraryId, newRouteNumPassengers);
                    break;
                
                case 6:
                    Console.Write("Введите id водителя: ");
                    int driverId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите название категории прав: ");
                    string rightsCategoryName = Console.ReadLine();

                    try
                    {
                        int newRightsCategoryId = DatabaseRequests.GetRightsCategoryId(rightsCategoryName);
                        DatabaseRequests.AddDriverRightsCategoryQuery(driverId, newRightsCategoryId);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                
                case 7:
                    Console.Write("Введите id водителя для просмотра его категорий прав: ");
                    int driverIdForRights = Convert.ToInt32(Console.ReadLine());
                    DatabaseRequests.GetDriverRightsCategoryQuery(driverIdForRights);
                    break;
                
                case 0:
                    return;

                default:
                    Console.WriteLine("Неверный выбор. Попробуйте еще раз.");
                    break;
            }

            Console.WriteLine();
        }
    }
}