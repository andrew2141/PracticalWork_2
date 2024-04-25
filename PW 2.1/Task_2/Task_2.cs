namespace Task_2;

public class Task_2
{
    static void Main(string[] args)
    {
        int[] candidates = { 10, 1, 2, 7, 6, 1, 5};
        int target = 8;

        var result = Combinations(candidates, target);    // получение результата
        
        Console.WriteLine("Комбинации: ");
        foreach (var combination in result)
        {
            Console.WriteLine(string.Join(", ", combination));
        }
    }

    static List<List<int>> Combinations(int[] candidates, int target)
    {
        Array.Sort(candidates);    //Сортировка массива по возрастанию

        List<List<int>> result = new List<List<int>>();    //хранение найденных комбинаций
        List<int> current = new List<int>();    //хранение текущей комбинации

        FindCombinations(candidates, target, 0, current, result);
        return result;
    }

    static void FindCombinations(int[] candidates, int target, int start, List<int> current, List<List<int>> result)
    {
        if (target == 0)    // проверка числа target на ноль
        {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = start; i < candidates.Length && target >= candidates[i]; i++)    // итерации по массиву candidates, начиная с индекса start, если число меньше или равно целевой сумме, добавляем его в комбинацию
        {
            if (i > start && candidates[i] == candidates[i - 1])    // пропускаем дублирующиеся элементы
            {
                continue;
            }
            
            current.Add(candidates[i]); 
            
            FindCombinations(candidates, target - candidates[i], i + 1, current, result);    // рекурсивно вызываем функцию с уменьшенной суммой
            current.RemoveAt(current.Count - 1);    // удаляем добавленное число 
        }
    }
}