//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//           по убыванию элементы каждой строки двумерного массива(в пределах всего массива).


int rows = 4;
int columns = 4;
int[,] array = new int[4, 4];
Random red = new Random();
NumbersArray();
Console.WriteLine("Массив для сортировки");
FillArray();
Console.WriteLine("Отсартированный массив");
void FillArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

void NumbersArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = red.Next(16);
        }
    }
}

void SortArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                if (array[i, k] < array[i, j])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    FillArray();
}
SortArray();
