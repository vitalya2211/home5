using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
            Напишите программу, которая покажет количество чётных чисел в массиве.
            [345, 897, 568, 234] -> 2*/
            void CreateArray( int[] Array,int Size,int min,int max)
             {
                int temp = 0;
                if(min>max)
                {
                    temp = max;
                    max = min;
                    min = temp;
                }
                Random rand = new Random();
                for (int i = 0; i < Array.Length; i++)
                    Array[i] = rand.Next(min, max);
                
            }
            void PrintArray(int[] Array)
            {
                for (int i = 0; i < Array.Length; i++)
                    Console.Write(Array[i] +"\t");
            }
            int CountFoo(int[] vs)
            {
                int count = 0;
                for (int i = 0; i < vs.Length; i++)
                {
                    if (vs[i]%2==0)
                        count++;

                }
                return count;
            }
            /*
            Задача 36: Задайте одномерный массив, заполненный случайными числами. 
            Найдите сумму элементов, стоящих на нечётных позициях.
            [3, 7, 23, 12] -> 19
            [-4, -6, 89, 6] -> 0*/
            int FindSum(int[]arr)
            {
                int sum = 0;
                for (int i=0;i<arr.Length;i++)
                {
                    if (i % 2 != 0)
                        sum += arr[i];
                }
                return sum;
            }
            /*
        
            Задача 38: Задайте массив вещественных чисел. Найдите разницу 
            между максимальным и минимальным элементов массива.
            [3 7 22 2 78] -> 76
            */
            int Find_Min_Max_diff(int[] arra)
            {
                int result=0;
                int min = 0;
                int max = 0;

                for(int i=0;i<arra.Length;i++)
                {
                    if (arra[min] > arra[i])
                        min = i;
                    else if (arra[max] < arra[i])
                        max = i;
                }
                Console.WriteLine("min= " + arra[min] + "\tmax= " + arra[max]);
                if (arra[min] > arra[max])
                    result = arra[min] - arra[max];
                else if (arra[max] > arra[min])
                    result = arra[max] - arra[min];
                return result;
            }
            int size,Min,Max;
            int[] array= { };
            int[] array2 = { };
            int[] array3 = { };
            Console.WriteLine("задать массив, заполненный случайными положительными трехзначными числами\n" +
                "вывести количество четных чисел в массиве:");
            Console.Write("введите количество цисел массива :");
            size = Convert.ToInt32(Console.ReadLine());
            array = new int[size];
            CreateArray(array,size,100,999);
            PrintArray(array);
            Console.WriteLine("количество четных чисел = " + CountFoo(array));
            Console.WriteLine("\nдля продолжения нажмите клавишу (любую)");
            Console.ReadKey();
            Console.WriteLine("задать одномерный массив, случайных чисел.\n найти сумму элементов, стоящих на четных позициях ");
            Console.Write("введите размeр массива: ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите предельные значения цифр:\n" +
                "минимальное значение: ");
            Min = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите максимальное значение:");
            Max = Convert.ToInt32(Console.ReadLine());
            array2 = new int[size];
            CreateArray(array2,size, Min, Max);
            PrintArray(array2);
            Console.WriteLine("сумма четных элементов массива = " + FindSum(array2));
            Console.WriteLine("для продолжения нажмите кнопочку");
            Console.ReadKey();
            Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу" +
                " между максимальным и минимальным элементов массива.");
            Console.Write("введите размер массива: ");
            size = Convert.ToInt32(Console.ReadLine());
            array3 = new int[size];
            Console.Write("введите минимальное значение: ");
            Min = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите максимальное значение: ");
            Max = Convert.ToInt32(Console.ReadLine());
            CreateArray(array3, size, Min, Max);
            PrintArray(array3);

            Console.WriteLine("разница между минимальным и максимальным элементом массива=" + Find_Min_Max_diff(array3));
            
            Console.ReadKey();

        }
    }
}
