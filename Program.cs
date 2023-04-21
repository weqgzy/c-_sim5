//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


int lenArray = ReadInt("введите длинну массива");

System.Console.Write("[ ");

double min = Int32.MaxValue;
double max = Int32.MinValue;

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1 , 19);
    System.Console.Write(randomArray[i] + ", ");

    if (randomArray[i] > max)
        {
            max = randomArray[i];
        }
    if (randomArray[i] < min)
        {
            min = randomArray[i];
        }
}


int ReadInt(string massage)
{
    System.Console.Write(massage + ":");
    return Convert.ToInt32(Console.ReadLine());

}

System.Console.Write("]");

System.Console.WriteLine($" максимальное - {max}, минимальное - {min}");
System.Console.WriteLine($" разница - {max - min}");