// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
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
int minCount = mas[0];
int maxCount = 0;
for (int j = 0; j < myArray.Length; j++)
{
    if (maxCount < mas[j])
    {
        maxCount = mas[j];
    }
    
    if (minCount >= mas[j])
    {
        minCount = mas[j];
    }   
}
Console.WriteLine($"\n Максимальный элемент: {maxCount}\n Минимальный элемент: {minCount}");
Console.WriteLine($"\nРазница между максимальным и минимальным элементом: {maxCount-minCount}");

