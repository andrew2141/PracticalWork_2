namespace Task_1;

public class Task_1
{
    class Student
    {
        public string Surname { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public string GroupNumber { get; set; }
        public int[] Grades { get; set; }

        public Student(string surname, DateTime dateOfBirthday, string groupNumber, int[] grades)
        {
            Surname = surname;
            DateOfBirthday = dateOfBirthday;
            GroupNumber = groupNumber;
            Grades = grades;
        }

        public void ChangeSurname(string newSurname)
        {
            Surname = newSurname;
        }

        public void ChangeDateOfBirthday(DateTime newDateOfBirthday)
        {
            DateOfBirthday = newDateOfBirthday;
        }

        public void ChangeGroupNumber(string newGroupNumber)
        {
            GroupNumber = newGroupNumber;
        }

        public void ChangeGrades(int[] newGrades)
        {
            Grades = newGrades;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Фамилия: {Surname}");
            Console.WriteLine($"Дата рождения: {DateOfBirthday.ToShortDateString()}");
            Console.WriteLine($"Номер группы: {GroupNumber}");
            Console.WriteLine("Успеваемость:");                                                         

            for (int i = 0; i < Grades.Length; i++)
            {
                Console.WriteLine($"Предмет {i + 1}: {Grades[i]}");
            }
        }
    }
    static void Main(string[] args)
    {
        int[] grades = { 5, 5, 5, 4, 4 };

        Student student = new Student("Шматухо", new DateTime(2006, 10, 15), "622", grades);

        Console.WriteLine("Информация о студенте: ");
        student.PrintInfo();
        
        student.ChangeSurname("new Шматухо");
        student.ChangeDateOfBirthday(new DateTime(2005, 9, 14));
        student.ChangeGroupNumber("624");

        Console.WriteLine("Обновлённая информация: ");
        student.PrintInfo();
    }
}