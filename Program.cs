using System.Text;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание А
            //Массив 1 Чи́сла Фибона́ччи
            int[] array1 = new int[8];
            array1[0] = 0;
            array1[1] = 1;
            Console.WriteLine("Выводим массив к заданию номер 1");
            for (int i = 2; i < array1.Length; i++)
            {
                array1[i] = array1[i - 1] + array1[i - 2];
            }

            Console.WriteLine("[{0}]", string.Join(", ", array1));

            //Массив 2 Месяца года
            string[] arrayMonth = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
            Console.WriteLine("===================================");
            Console.WriteLine("Выводим массив к заданию номер 2");
            Console.WriteLine("[{0}]", string.Join("", arrayMonth));

            //Массив 3 Двумерный массив 3x3
            int[][] array3 = new int[][] { new int[] { 2, 3, 4 }, new int[] { 4, 9, 16 }, new int[] { 8, 27, 64 }, };

            Console.WriteLine("===================================");
            Console.WriteLine("Выводим массив к заданию номер 3");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < array3[i].Length; j++)
                {
                    Console.Write("{0,3}", array3[i][j]);
                }
                Console.WriteLine();
            }

            //Массив 4 Ломанный массив
            double[][] array4 = new double[3][] {
                new double[5] {1, 2, 3, 4, 5},
                new double[2] {Math.E,Math.PI},
                new double[4] { Math.Log(1, 10), Math.Log(10, 10), Math.Log(100, 10), Math.Log(1000, 10) }
            };

            Console.WriteLine("===================================");
            Console.WriteLine("Выводим массив к заданию номер 4");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < array4[i].Length; j++)
                {
                    Console.Write("{0,3}", array4[i][j]);
                }
                Console.WriteLine();
            }


            //Задание Б
            //Массив 5 Скопировать первые 3 элемента первого массива во второй
            int[] array5_1 = { 1, 2, 3, 4, 5 }; 
            int[] array5_2 = { 7, 8, 9, 10, 11, 12, 13 };
            Array.Copy(array5_1, array5_1.GetLowerBound(0), array5_2, array5_2.GetLowerBound(0), 3);

            Console.WriteLine("===================================");
            Console.WriteLine("Выводим массив к заданию номер 5");
            Console.WriteLine("[{0}]", string.Join(", ", array5_2));

            //Массив 6 Изменить размер первого массива
            Console.WriteLine("===================================");
            Console.WriteLine("Выводим массив к заданию номер 6");
            Array.Resize(ref array5_1, array5_1.Length * 2 );
            Console.WriteLine("[{0}]", string.Join(", ", array5_1));


        }
    }
}