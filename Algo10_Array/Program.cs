using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo10_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 20; //максимальный размер массива (константа)
            const int FINISH = 0; //признак окончания ввода

            int[] a = new int[SIZE]; //создание массива (выделение памяти под массив размера SIZE)
            int n = 0; //счетчик
            int t;

            do
            {
                Console.WriteLine("Введите элемент массива");
                t = int.Parse(Console.ReadLine());
               
                a[n] = t; //заносим элемент в массив по индексу n
                n++; //увеличиаем счетчик
            } 
            while (t != FINISH && n < SIZE); //пока не достигли максим размера массива или пока пользователь не ввел 0

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(a[i] + " ");
            //}

            Console.ReadLine();
        }
    }
}
