// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
            matr [i] = new Random().Next (-10, 10);
    }
}

int summa = 0;
int Sum (int [] matr)
{
    for (int i = 0; i < matr.GetLength (0); i = i+2)
    {
            summa = summa + matr[i];
    }
    Console.WriteLine($"Cумма элементов,стоящих на нечётных позициях равна {summa}"); 
    return summa;  
}


int  [] matrix = new int [4];
FillArray (matrix);
PrintArray (matrix);
Sum (matrix);
