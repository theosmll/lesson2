using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less2
{
    class Program
    {
        //Горшунова Алла
        static void Task1()
        {
            //Написать метод, возвращающий минимальное из трех чисел.
            Console.Clear();
            Console.WriteLine("Введите три целых числа:");
            Console.Write("Введите первое число: ");
            var x = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            var y = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            var z = int.Parse(Console.ReadLine());
            int min = 0;
            if (x < y && x < z)
            {
                min = x;
            }
            else if (y < x && y < z)
            {
                min = y;
            }
            else
            {
                min = z;
            }

            Console.WriteLine($"Минимальное число: {min}");

        }
        static void Task2()
        {
            //Написать метод подсчета количества цифр числа.
            Console.Clear();
            Console.WriteLine("Введите целое число");

            int num = int.Parse(Console.ReadLine());
            int i = 0;
            while (num > 0)
            {
                i++;
                num /= 10;
            }
            Console.WriteLine($"Количество цифр введенного числа : {i}");
            Console.ReadKey();


        }
        static void Task3()
        {
            //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            Console.Clear();
            Console.WriteLine("Введите несколько чисел. Чтобы подсчитать сумму нечетных положительных чисел введите 0");

            int sum = 0;
            int a;
            do
            {
                Console.WriteLine("Введите целое число");
                a = int.Parse(Console.ReadLine());
                double b = a % 2;
                if (b != 0)
                {
                    sum = sum + a;
                }


            } while (a != 0);

            Console.WriteLine(sum);
            Console.ReadLine();


        }
        static void Task4()
        {
            //Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
            //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
            //Используя метод проверки логина и пароля, написать программу:
            //пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
            //С помощью цикла do while ограничить ввод пароля тремя попытками.
            Console.Clear();
            string login = "root";
            string password = "GeekBrains";
            string user1;
            string user2;
            int count = 0;
            do
            {
                Console.WriteLine("Введите логин");
                user1 = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                user2 = Console.ReadLine();
                if (user1 == login && user2 == password)
                {
                    Console.WriteLine("Всё верно");
                    break;
                }
                else
                {
                    Console.WriteLine("Логин или пароль были введены не верно");

                    count++;
                }
            } while (count != 3);


        }
        static void Task5()
        {
            //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

            Console.Clear();
            Console.WriteLine("Давайте посчитаем ИМТ");

            double m;
            double h;

            Console.WriteLine("Введите свой вес в киллограммах");
            m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите свой рост в сантиметрах");
            h = double.Parse(Console.ReadLine());
            h = h / 100;

            double I = m / (h * h);

            Console.WriteLine($"Ваш ИМТ = {Math.Round(I, 2)}");

            if (I < 18.49 && I > 16)
            {
                //double c;
                Console.WriteLine("У вас недостаточная масса. Рекомендуется набрать вес");
                do
                {
                    m++;
                    I = m / (h * h);
                } while (I == 18.49);
                Console.WriteLine($"Для нормы вам нужно набрать: {Math.Round(I, 2)} кг.");
            }
            else if (I < 24.99 && I > 18.50)
            {
                Console.WriteLine("Ваша масса тела соответствует норме");
            }
            else if (I > 25)
            {
                Console.WriteLine("Ваша масса тела превышает норму");
                do
                {
                    m--;
                    I = m / (h * h);
                } while (I == 25);


                Console.WriteLine($"Для нормы вам рекомендуется похудеть на: {Math.Round(I, 2)} кг.");
            }

            Console.ReadLine();

        }
        static void Task6()
        {
            //*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
            //    «Хорошим» называется число, которое делится на сумму своих цифр.
            //    Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

            DateTime start = DateTime.Now;
            long i = 1;
            int k = 0;
            do
            {
                var x = i % Rs(i);
                if (x == 0)
                {
                    k++;
                    Console.WriteLine(k);
                }
                i++;
            } while (i <= 1000000000);
            Console.WriteLine(k);
            Console.WriteLine(DateTime.Now - start);
        }
        static void Task7()
        {
            //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
            //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
            Loop(3, 13);
            Console.ReadLine();
            //Не до конца поняла как вывести корректный результат
            Sum(1, 10, 0);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите задачу, которую хотите посмотреть.");
            Console.WriteLine("1. Получение минимального числа");
            Console.WriteLine("2. Подсчет количества цифр числа");
            Console.WriteLine("3. Подсчет суммы чисел");
            Console.WriteLine("4. Проверка логина и пароля");
            Console.WriteLine("5. Индекс Массы тела");
            Console.WriteLine("6. Подсчёт количество хороших цифр");
            Console.WriteLine("0 - завершение работы программы");
            int no = 0;
            Console.Write("Введите номер задачи: ");
            no = int.Parse(Console.ReadLine());
            switch (no)
            {
                case 0:
                    break;
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
                case 6:
                    Task6();
                    break;
                case 7:
                    Task7();
                    break;
                default:
                    Console.WriteLine("Номер задачи введен некорректно. Пожалуйста, повторите попытку ввода.");
                    break;
            } while (no != 0) ;
            Console.WriteLine("Завершение работы программы ...");
            Console.ReadKey();
        }

        static long Rs(long a)
        {
            if (a == 0)
                return 0;
            else return Rs(a / 10) + a % 10;
        }

        static void Loop(int a, int b)
        {
            Console.Write("{0} ", a);
            if (a < b) Loop(a + 1, b);
        }
        static void Sum(int a, int b, int s)
        {
            if( a <= b)
            {
                s += a;
                Sum(a + 1, b, s);
            }
            Console.WriteLine(s); 
        }
    }
}
    

