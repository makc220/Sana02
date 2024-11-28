Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Введіть 5 оцінок студента (за 100-бальною шкалою):");
double[] grades = new double[5];
for (int i = 0; i < 5; i++)
{
    Console.Write($"Оцінка {i + 1}: ");
    grades[i] = Convert.ToDouble(Console.ReadLine());
}

double average = 0;
foreach (var grade in grades)
{
    average += grade;
}
average /= grades.Length;

Console.WriteLine($"Середній бал: {average}");
if (average >= 50)
{
    Console.WriteLine("Студент допущений до екзамену.");
}
else
{
    Console.WriteLine("Студент не допущений до екзамену.");
}