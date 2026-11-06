class Program
{
    static void Main(string[] args)
    {
        int[] grades = { 75, 90, 45, 60, 85, 30, 95, 70 };

        for (int i = 0; i < grades.Length; i++)
        {
            Console.WriteLine($"student {i + 1}: {grades[i]}");
        }

        Console.WriteLine(" ");
        Console.WriteLine($"Average Grade: {CalculateAverage(grades)}");
        Console.WriteLine($"Max Grade: {FindMax(grades)}");
        Console.WriteLine($"Min Grade: {FindMin(grades)}");

        Console.WriteLine(" ");

        Console.WriteLine("Calculate average: ");
        Console.WriteLine(CalculateAverage(70, 90));
        Console.WriteLine(CalculateAverage(60, 75, 90));
        Console.WriteLine(CalculateAverage(grades));

        Console.WriteLine(" ");

        Console.WriteLine("Calculate total: ");
        Console.WriteLine(CalculateTotal(10, 20));
        Console.WriteLine(CalculateTotal(10, 20, 30));
        Console.WriteLine(CalculateTotal(grades));
        Console.WriteLine(CalculateTotal());
    }

    static double CalculateAverage(int[] grades)
    {
        double average = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            average = average + grades[i];
        }
        average = average / grades.Length;
        return average;
    }

    static double CalculateAverage(int grade1, int grade2)
    {
        return (grade1 + grade2) / 2.0;
    }

    static double CalculateAverage(int grade1, int grade2, int grade3)
    {
        return (grade1 + grade2 + grade3) / 3.0;
    }
    
    static int FindMax(int[] grades)
    {
        int max = grades[0];
        for (int i = 0; i < grades.Length; i++)
        {
            if (grades[i] > max)
            {
                max = grades[i];
            }
        }
        return max;
    }

    static int FindMin(int[] grades)
    {
        int min = grades[0];
        for (int i = 0; i < grades.Length; i++)
        {
            if (grades[i] < min)
            {
                min = grades[i];
            }
        }
        return min;
    }

    static int CalculateTotal(params int[] grades)
    {
        int total = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            total = total + grades[i];
        }
        return total;
    }
}
