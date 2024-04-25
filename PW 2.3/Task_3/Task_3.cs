namespace Task_3;

public class Task_3
{
    class Calculation
    {
        private string calculationLine;

        public Calculation(string CalculationLine)
        {
            calculationLine = CalculationLine;
        }

        public void SetCalculationLine(string line)
        {
            calculationLine = line;
        }

        public void SetLastSymbolCalculationLine(char symbol)
        {
            calculationLine += symbol;
        }

        public string GetCalculationLine()
        {
            return calculationLine;
        }
        
        public void GetLastSymbol()
        {
            if (calculationLine.Length > 0)
            {
                Console.WriteLine(calculationLine[calculationLine.Length - 1]);
            }
            else
            {
                Console.WriteLine("Строка пустая");
            }
        }
        
        public void DeleteLastSymbol()
        {
            if (calculationLine.Length > 0)
            {
                calculationLine = calculationLine.Substring(0, calculationLine.Length - 1);
            }
            else
            {
                Console.WriteLine("Строка пустая");
                return;
            }
        }
    }
    
    static void Main(string[] args)
    {
        Calculation calc = new Calculation(" ");
        
        calc.SetCalculationLine("ABC + 456");
        Console.WriteLine(calc.GetCalculationLine());
        
        calc.SetLastSymbolCalculationLine('=');
        
        Console.WriteLine(calc.GetCalculationLine());
        
        calc.GetLastSymbol();
        
        calc.DeleteLastSymbol();
        Console.WriteLine(calc.GetCalculationLine());
    }
}