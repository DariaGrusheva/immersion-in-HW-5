
// Дан массив и число. Найдите три числа в массиве сумма которых равна искомому числу.
// Подсказка: если взять первое число в массиве, можно ли найти в оставшейся его части два числа равных по сумме первому.

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 8, 6, 5 };
            int target = 12;


            HashSet<int> set1 = new HashSet<int>();

            for (int i = 0; i < array.Length; i++)
            {
                int temp = target - array[i];
                for (int j = 0; j < array.Length; j++)
                {
                    if (set1.Contains(temp - array[j]) && temp - array[j] != 0 && temp - array[j] != array[j])
                    {
                        Console.WriteLine($"{array[i]} + {array[j]} + {temp - array[j]} = {target}");


                        return;
                    }
                    else { set1.Add(i); }
                }
            }
            Console.WriteLine("Числа не найдены");
        }
    }
}