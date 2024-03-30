public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Введите размер массива n x m:");
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());

        int[,] twoMass = new int[n, m];
        PrintMass(twoMass);
        MostPositiveNumber(twoMass);
        PositiveLine(twoMass);

    }

    public static void PositiveLine(int[,] twoMass)
    {
        int maxIsPositive = 0;
        int rowPositive = -1;

        for (int i = 0; i < twoMass.GetLength(0); i++)
        {
            int isPositive = 0;

            for (int j = 0; j < twoMass.GetLength(1); j++)
            {
                if (twoMass[i, j] > 0)
                {
                    isPositive++;
                }
            }
            if (isPositive > maxIsPositive)
            {
                maxIsPositive = isPositive;
                rowPositive = i;
            }
        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Строка с наибольшим количеством положительных элементов: " + (rowPositive + 1));
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void MostPositiveNumber(int[,] twoMass)
    {
        bool check = false;
        for (int i = 0; i < twoMass.GetLength(0); i++)
        {

            for (int j = 0; j < twoMass.GetLength(1); j++)
            {
                if (twoMass[i, j] > 0)
                {
                    check = true;
                }
            }
        }
        Console.WriteLine();
        if (check == true)
        {
            for (int i = 0; i < twoMass.GetLength(0); i++)
            {
                for (int j = 0; j < twoMass.GetLength(1); j++)
                {
                    if (twoMass[i, j] >= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Положительный элемент: строка {0} столбец {1}", i + 1, j + 1, ";\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (twoMass[i, j] < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Отрицательный элемент: строка {0} столбец {1}", i + 1, j + 1, ";\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
    }

    public static void PrintMass(int[,] twoMass)
    {
        for (int i = 0; i < twoMass.GetLength(0); i++)
        {
            for (int j = 0; j < twoMass.GetLength(1); j++)
            {
                Random random = new Random();
                twoMass[i, j] = random.Next(-50, 100);
            }
        }
        Console.WriteLine();
        Console.WriteLine("Первоначальный массив: ");
        for (int i = 0; i < twoMass.GetLength(0); i++)
        {
            for (int j = 0; j < twoMass.GetLength(1); j++)
            {
                Console.Write(twoMass[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}