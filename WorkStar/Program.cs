// алгоритм сортировки методом пузырька. 
//Реализовать невозрастающую сортировку.
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

int temp = 0;

for (int j = 0; j < mas.Length; j++) 
{
    for (int sort = 0; sort < mas.Length - 1; sort++) 
    {
        if (mas[sort] > mas[sort + 1]) {
            temp = mas[sort + 1];
            mas[sort + 1] = mas[sort];
            mas[sort] = temp;
        }
    }
}
Console.WriteLine("Вывод элементов сортированного массива: ");
for (int i = 0; i < mas.Length; i++)
    
    Console.Write(mas[i] + " ");