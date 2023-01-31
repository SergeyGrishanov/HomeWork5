// // Задайте массив заполненный случайными положительными трёхзначными числами. 
// //Напишите программу, которая покажет количество чётных чисел в массиве
Console.Clear();

Console.Write("Введите количество элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine()!);
    
int[] myArray = new int[elementsCount];

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = new Random().Next(100, 1000);
    
}

Console.WriteLine("Вывод элементов массива: ");
Console.WriteLine(String.Join(", ", myArray));

int[] mas = myArray;
int num = 0;
int count = 0;
for (int j = 0; j < myArray.Length; j++)
{
    while (mas[j] > 0)
    {
        num = mas[j] % 10;
        mas[j] = mas[j] / 10;

        if (num % 2 == 0)
        {
            count++;
        }
        else
        {
            count = count + 0;
        }
    }    
}

Console.WriteLine("Вывод количества четных чисел: ");
Console.WriteLine(String.Join(", ", count));





