using System.Text;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 Чи́сла Фибона́ччи
            int[] array1 = new int[10];
            array1[0] = 0;
            array1[1] = 1;
            Console.WriteLine("Задание 1");
            for (int i = 2; i < array1.Length; i++)
            {
                array1[i] = array1[i - 1] + array1[i - 2];
            }

            Console.WriteLine("[{0}]", string.Join(", ", array1));


            //Задание 2 Нечетные числа
            Console.WriteLine("Задание 2");
            for (int i = 2; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" " + i);
                }
            }
            Console.WriteLine();

            //Задание 3 Умножение
            Console.WriteLine("Задание 3");
            for (int i =1; i <= 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int a = i * j;
                    Console.Write(" " + a);
                }
                Console.WriteLine();
            }
            //Задание 4 Пароль
            string password = "qwerty";
            string enterPassword = "";
            Console.WriteLine("Задание 4"); 
            do
            {
                Console.WriteLine("Введите пароль:");
                enterPassword = Console.ReadLine();
                if ( enterPassword == password)
                {
                    Console.WriteLine("Пароль верный");
                }
                else
                {
                    Console.WriteLine("Пароль неверный");
                }
            }
            while (password != enterPassword);
        }
    }
}