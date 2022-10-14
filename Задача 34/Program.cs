

/* 
1 Задайте массив заполненный случайными положительными трёхзначными числами. 
2 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
 */


int[] FillArrayWithRandom3Numbers(int[] InputArray)
{
    int[] FilledArray = new int[InputArray.Length];

    for (int i = 0; i < InputArray.Length; i++)
    {
        FilledArray[i] = new Random().Next(100, 999);
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

int CountNumberThatCanBeDividedByTwo(int[] InputInternalArray)
{
    int FinalNumber = 0;
    for (int i = 0; i < InputInternalArray.Length; i++)
    {
        if (InputInternalArray[i] % 2 == 0)
        {
            FinalNumber++;
        }
    }
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
Console.Write("количество чётных чисел в массиве = ");
Console.Write(CountNumberThatCanBeDividedByTwo(SuperFinalArray));