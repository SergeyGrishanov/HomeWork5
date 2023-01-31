//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();

Console.Write("Введите количество элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine()!);
    
int[] myArray = new int[elementsCount];

for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = new Random().Next(1, 100);
    
}

Console.WriteLine("Вывод элементов массива: ");
Console.WriteLine(String.Join(", ", myArray));

int[] mas = myArray;

int count = 0;
for (int j = 0; j < myArray.Length; j++)
{
    if (j % 2 != 0)
    {
        count = count + mas[j];
    }
    else
    {
        count = count + 0;
    }
}    


Console.WriteLine("Вывод суммы чисел на нечетных позициях: ");
Console.WriteLine(String.Join(", ", count));