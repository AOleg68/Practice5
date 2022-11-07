// Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void PrintArray( double[] matr)
{
    for (int i = 0; i < matr.GetLength (0); i ++)
    {
    Console.Write ($"{matr[i]}  ");
    }
    Console.WriteLine (); 
}

void FillArray (double [] matr)
{
    for (int i = 0; i < matr.GetLength (0); i ++)
    {
            matr [i] = new Random().Next (1, 100);
    }
}

double max = 0;
double min = Int32.MaxValue;
double dif = 0;
double DifMaxMin (double [] matr)
{
    for (int i = 0; i < matr.GetLength (0); i++)
    {
        if (matr [i] > max) 
        {
            max = matr[i];
        }
        if (matr [i] < min)
        {
            min = matr[i];
        }          
    }

    dif = max - min;
    Console.WriteLine($"Максимальное значение = {max}");
    Console.WriteLine($"Минимальное значение = {min}");
    Console.WriteLine();
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {dif}"); 
    return dif;  
}

double [] matrix = new double [10];
FillArray (matrix);
PrintArray (matrix);
DifMaxMin (matrix);