// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void PrintArray(int[] matr)
{
    for (int i = 0; i < matr.GetLength (0); i ++)
    {
    Console.Write ($"{matr[i]}  ");
    }
    Console.WriteLine (); 
}

void FillArray (int [] matr)
{
    for (int i = 0; i < matr.GetLength (0); i ++)
    {
            matr [i] = new Random().Next (1, 100);
    }
}
int count = 0;
int EvenNumbers (int [] matr)
{
    for (int i = 0; i < matr.GetLength (0); i ++)
    {
        if (matr [i] % 2 == 0)  count++;
        
    }
    Console.WriteLine($"Всего {matr.Length} чисел, из которых {count} чётные"); 
    return count;    
}



int  [] matrix = new int [100];
FillArray (matrix);
PrintArray (matrix);
EvenNumbers (matrix);
