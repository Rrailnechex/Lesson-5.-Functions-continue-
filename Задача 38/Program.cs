


/* 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
 */


int[] FillArrayWithRandom3Numbers(int[] InputArray)
{
    int[] FilledArray = new int[InputArray.Length];

    for (int i = 0; i < InputArray.Length; i++)
    {
        FilledArray[i] = new Random().Next(-9, 9);
    }

    return FilledArray;
}

void PrintArray(int[] InputInternalArray)
{
    Console.Write("Массив = ");
    Console.Write("[");
    for (int i = 0; i < InputInternalArray.Length; i++)
    {
        Console.Write(InputInternalArray[i]);
        if (i < InputInternalArray.Length - 1) { Console.Write(", "); }
    }
    Console.Write("]");
    Console.WriteLine();
}

int DifferenceBetweenMinAndMaxElements(int[] InputInternalArray)
{
    Array.Sort(InputInternalArray);
    int MAX = InputInternalArray[InputInternalArray.Length - 1];
    int MIN = InputInternalArray[0];

    int FinalNumber = Math.Abs(MAX - MIN);

    return FinalNumber;
}

void DoLine()
{
    Console.WriteLine("-----------------------------");
}






Console.Write("Введите количество чисел в массиве: ");
int NomberOfNombersInArray = int.Parse(Console.ReadLine());

int[] TheArrayForTransformation = new int[NomberOfNombersInArray];



int[] SuperFinalArray = FillArrayWithRandom3Numbers(TheArrayForTransformation);

PrintArray(SuperFinalArray);
DoLine();
Console.Write("сумма элементов, стоящих на нечётных позициях = ");
Console.Write(DifferenceBetweenMinAndMaxElements(SuperFinalArray));