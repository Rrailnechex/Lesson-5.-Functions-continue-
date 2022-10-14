


/* 
1 Задайте одномерный массив, заполненный случайными числами. 
2 Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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

int SummOfNechetnyhElementsInArray(int[] InputInternalArray)
{
    int FinalNumber = 0;
    for (int i = 0; i < InputInternalArray.Length; i++)
    {
        if (i % 2 == 0)
        {
            FinalNumber = FinalNumber + InputInternalArray[i];
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
Console.Write("сумма элементов, стоящих на нечётных позициях = ");
Console.Write(SummOfNechetnyhElementsInArray(SuperFinalArray));