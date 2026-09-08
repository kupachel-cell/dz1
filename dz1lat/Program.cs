using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace dz1lat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1


            //Console.WriteLine($"Число e с точностью до десятых равно: {Math.Round(Math.E, 1)}");


            //Console.ReadKey();


            //Задание 2

            //Console.WriteLine(50);
            //Console.WriteLine(10);


            //Console.ReadKey();


            //Задание 3

            //Random random1 = new Random();

            //Console.WriteLine(random1.Next()+ "\n"+ random1.Next()+ "\n"+ random1.Next()+"\n"+ random1.Next());



            //Console.ReadKey();

            //Задание 4

            //Console.WriteLine("Введите число");

            //double number = double.Parse(Console.ReadLine());

            //Console.WriteLine($"{number+10} больше введенного вами на 10");

            //Console.ReadKey();

            //Задание 5
            //Console.WriteLine("Введите переменную x");

            //double x = double.Parse(Console.ReadLine());

            //Console.WriteLine($"y равен {Math.Cos(x)}");

            //Console.ReadKey();

            //Задание 6

            //Console.WriteLine("Укажите высоту трапеции");
            //int height = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Укажите первое основание трапеции");
            //int base1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Укажите второе основание трапеции");
            //int base2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Периметр трапеции равен {Math.Sqrt((Math.Abs(base1-base2)/2)* (Math.Abs(base1 - base2) / 2)+height*height)}");
            //Console.ReadKey();


            //Задание 7

            //Console.WriteLine("Мир Труд Май");
            //Console.WriteLine("Мир  \n    Труд  \n         Май");

            //Console.ReadKey();


            //Задание 8

            //Console.WriteLine("Введите первое число:")
            //int firstnumber =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите второе число:");
            //int secondnumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{secondnumber} {firstnumber}");
            //Console.ReadKey();

            //Задание 9

            //Console.WriteLine("Введите число");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Вы ввели число {num} ");
            //Console.ReadKey();

            //Задание 10



            //Console.WriteLine("Ведите коэффицент a");
            //float a = float.Parse(Console.ReadLine());
            //Console.WriteLine("Введите коэффицент b");
            //float b = float.Parse(Console.ReadLine());
            //Console.WriteLine("Введите коэффицент c");
            //float c = float.Parse(Console.ReadLine());
            //float d = b*b - 4 * a * c;

            //if (d>0){
            //    Console.WriteLine($"Первый x равен{(-b-(MathF.Sqrt(d)))/(2*a)}, второй  x равен {(-b+(MathF.Sqrt(d)))/(2*a)}");


            //}
            //else if (d==0){
            //    Console.WriteLine($"X равен {(-b)/(2*a)}");
            //}
            //else
            //{
            //    Console.WriteLine("Дискриминант меньше нуля, нет решения");
            //}


            //Console.ReadKey();

            //Задание 11

            //Console.WriteLine("Введите первое число");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите второе число");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Среднее арифметическое этих чисел равно {(num1+num2)/2}");
            //Console.WriteLine($"Среднее геометрическое этих чисел равно {Math.Sqrt(num1*num2)}");

            //Console.ReadKey();

            //Задание 12

            //Console.WriteLine("Введите координату  x первой точки");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите координату  y первой точки");
            //double y1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите координату  x второй точки");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите координату  y второй точки");
            //double y2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Расстояние между этими точками {Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1))}");

            //Console.ReadKey();

            //Задание 13

            //Console.WriteLine("Введите числовое значение для  a");
            //int a1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите числовое значение для  b");
            //int b1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите числовое значение для  c");
            //int c1 = Convert.ToInt32(Console.ReadLine());
            //int d1 = a1;

            //a1 = b1;
            //b1 = c1;
            //c1 = d1;
            //Console.WriteLine($"a={a1}, b={b1},c={c1}");

            //Console.WriteLine("Введите новое числовое значение для  a");
            //int a2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите новое числовое значение для  b");
            //int b2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите новое числовое значение для  c");
            //int c2 = Convert.ToInt32(Console.ReadLine());
            //int d2 = c2;

            //c2 = b2;
            //b2 = a2;
            //a2 = d2;
            //Console.WriteLine($"a={a2}, b={b2},c={c2}");

            //Console.ReadKey();



            //Задание 14


            //Console.WriteLine("Введите число секунд, прошедших с начала суток");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int hour = n / 3600;
            //int minute = ((n - 3600 * (n / 3600)) / 60);
            //int second = n;
            //if (hour > 0 && minute>0)
            //{
            //    second = n - hour*3600-minute*60;



            //}
            //else if(minute>0)
            //{
            //     second = n-minute*60;
            //}
            //else if (hour > 0)
            //{
            //    second = n - hour * 3600;
            //}
            //else
            //{
            //     second = n;
            //}
            //Console.WriteLine($" прошло часов:  {hour} , прошло минут:  {minute} , прошло секунд: {second}");

            //Console.ReadKey();

            //Задание 15

            //int length = 543;
            //int wigth = 130;
            //Console.WriteLine($"Поместится {length*wigth/130/130} квадрата со стороной 130 мм");

            //Console.ReadKey();

            //Задание 16

            //int num1 = 987;
            //int num2 = (num1 % 10) * 100 + (num1 % 100);
            //Console.WriteLine($"Получено число {num2}");

            //Console.ReadKey();

            //Задание 17

            //Console.WriteLine("Введите число");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int thousands = number / 1000;
            //int hundreds = (number - thousands * 1000 - number % 100)/100;
            //Console.WriteLine($"В этом числе {(hundreds)} сотен , {thousands} тысяч");


            //Console.ReadKey();

            //Задание 18

            //Console.WriteLine("Назовите свое имя");
            //string name = Console.ReadLine();
            //Console.WriteLine($"{name}");
            //Console.WriteLine($"Привет,{name}");

            //Console.ReadKey();


            //Задание 19

            Random random1 = new Random();
            int numberofcolor = random1.Next(0, 16);
            
            Console.WriteLine("*Поприветствуйте Тома Реддла");
            string hi = Console.ReadLine();
            if (hi=="Привет"|| hi=="Здравствуйте") {
                Console.WriteLine("Здравствуй, как тебя зовут?");
                string name = Console.ReadLine();
                Console.WriteLine($"Привет, {name}");
                Console.WriteLine("Ты знаешь что-то о тайной комнате?");
                Console.WriteLine("Да");
                Console.WriteLine("Можешь рассказать о ней");
                Console.WriteLine("Нет");
                Thread.Sleep(2000);
                Console.WriteLine("Но могу показать");
                Console.BackgroundColor = (ConsoleColor)numberofcolor;
            }
            

        }
    }
}
