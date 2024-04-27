class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Логические операторы двух чисел");
        Console.WriteLine("Введите первое число");
        if (!int.TryParse(Console.ReadLine(), out int a)) 
        {
            Console.WriteLine("Введенное число не int");
            return;
        }
        Console.WriteLine("Введите второе число");
        if (!int.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine("Введенное число не int");
            return;
        }
        Console.WriteLine("Введите один из логических операторов:  & | или ^");
        var s = Console.ReadLine();
        if (s != "&" && s != "|" && s != "^")   
        {
            Console.WriteLine("Введен не верный символ");
            return;
        }

        switch(s[0]) 
        {
            case '&':
            {
                Console.WriteLine("Результат {0} & {1} = {2}", a, b, a & b);
                Console.WriteLine("Результат в двоичной форме:" + Convert.ToString(a & b,2));
                Console.WriteLine("Результат в шеснадцатиричной форме:" + Convert.ToString(a & b, 16));
                break;
            }
            case '|':
                {
                    Console.WriteLine("Result of {0} | {1} = {2}", a, b, a | b);
                    Console.WriteLine("Результат в двоичной форме:" + Convert.ToString(a | b, 2));
                    Console.WriteLine("Результат в шеснадцатиричной форме:" + Convert.ToString(a | b, 16));
                    break;
                }
            case '^':
                {
                    Console.WriteLine("Result of {0} ^ {1} = {2}", a, b, a ^ b);
                    Console.WriteLine("Результат в двоичной форме:" + Convert.ToString(a ^ b, 2));
                    Console.WriteLine("Результат в шеснадцатиричной форме:" + Convert.ToString(a ^ b, 16));
                    break;
                }

            default:
            {
                Console.WriteLine("Wrong sign");
                break;
            }
        }
    }
}