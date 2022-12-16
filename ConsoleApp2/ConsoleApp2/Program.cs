using System.Linq.Expressions;

Console.WriteLine("Введите количество элементов в одномерной матрице.");
int n = int.Parse(Console.ReadLine());
double max = 0;
double[] mas = new double[n];
double m = 0;
string mm;
Console.WriteLine("Заполняем массив.");
for (int i = 0; i < n; i++)
{
    mm = Console.ReadLine();
    while (double.TryParse(mm, out mas[i]) == false)
    {
        Console.WriteLine("Ошибка! Вы ввели не то, что надо. Вводите цифры.");
        mm = Console.ReadLine();
    }
    mas[i] = double.Parse(mm);
}
m = 0;
Console.WriteLine("Максимальный элемент.");
for(int i = 0; i<n;i++)
{
    if (mas[i] > max)
    {
        max = mas[i];
    }
}
Console.WriteLine(max);
Console.WriteLine("Сумма элементов до последнего положительного.");
for(int i = n - 1; i >= 0; i--)
{
    if (mas[i] >= 0)
    {
        for(int j = 0; j < i; j++)
        {
            m = m + mas[j];
        }
        break;
    }
}
Console.WriteLine(m);
Console.WriteLine("Введите значение параметров а и b:");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
for (int i = 0, j = 0; i < n;)
{
    if (j < n)
    {
        if (!(mas[j] >= a && mas[j] <= b))
        {
            i++;
        }
        
        mas[i] = ++j < n ? mas[j] : 0;
    }
    else
    {
        mas[i++] = 0;
    }
}
for (int i = 0; i < n; i++)
{
    Console.WriteLine(mas[i]);
}
/////////////////////////////////////////////////////////////////////////////////
Console.WriteLine("Введите границы квадратной матрицы n x n");
n = int.Parse(Console.ReadLine());
int[,] mass = new int[n, n];
for(int i =0; i<n;i++)
{
    for(int j =0; j<n;j++)
    {
        mass[i,j] = int.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(mass[i, j]);
        Console.Write(" ");
    }
    Console.Write("\n");
}
Console.WriteLine("Сумма элементов в тех столбцах, которые не содержат отрицательных элементов.");
int sum = 0;
int h = 0;
for (int j = 0; j < n; j++)
{
    for (int i = 0; i < n; i++)
    {
        if (mass[i,j] >= 0)
        {
            h = 1;
            sum = sum + mass[i, j];
        }
        else
        {
            h = 0;
            sum = 0;
            break;
        }
    }
    if (h == 1)
    {
        Console.WriteLine($"Столбец {j+1}. Сумма {sum}");
    }
    h = 0;
}
Console.WriteLine("Минимум среди сумм модулей элементов диагоналей, параллельных побочной диагонали матрицы.");
sum = 0;
for (int i = 0; i < n; i++)
{
    sum += Math.Abs(mass[i, n - 1 - i]);
}
int min = sum;
for (int k = 1; k != n; k++)
{
    int sum1 = 0;
    int sum2 = 0;
    for (int i = n - 1, j = 0; i >= k; i--, j++)
    {
        sum1 += Math.Abs(mass[i - k, j]);
        sum2 += Math.Abs(mass[i, j + k]);
    }
    min = Math.Min(min, Math.Min(sum1, sum2));
}
Console.WriteLine("Минимум: " + min);
Console.Read();