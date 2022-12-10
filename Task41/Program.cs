// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//Вводим сразу все числа в одну линию, не через бесконечное кол-во ReadLine.
Console.WriteLine("Введите колличество элементов в одномерном массиве, который хотите создать:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите все значения элементов массива, используя разделитель ' '(пробел). Их должно быть ровно {m}!");
double[] array = Console.ReadLine().Split(' ').Select(х => double.Parse(х)).ToArray();
if (array.Length != m) 
{ 
    Console.WriteLine("Вы ввели неверное количество элементов.");
}
else
{
    Console.WriteLine($"В массиве {string.Join(" ",array)}, чисел больше 0 - {Pol(m,array)} .");
}

int Pol (int m, double[] array)
{
    int col = 0;
    for (int i=0; i<m; i++)
    {
        if (array[i] > 0 )
        {
            col++;
        }
    }
    return col;
}