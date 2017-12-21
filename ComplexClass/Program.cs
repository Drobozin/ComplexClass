using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите вещественную часть комплексного числа №1: ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть комплексного числа №1: ");
            double b = Double.Parse(Console.ReadLine());

            Console.Write("Введите вещественную часть комплексного числа №2: ");
            double a1 = Double.Parse(Console.ReadLine());
            Console.Write("Введите мнимую часть комплексного числа №2: ");
            double b1 = Double.Parse(Console.ReadLine());

            ComplexClass complex1 = new ComplexClass(a, b);
            ComplexClass complex2 = new ComplexClass(a1, b1);

            Console.WriteLine("Комплексное число №1: " + complex1);
            Console.WriteLine("Комплексное число №2: " + complex2);


            ComplexClass sum = complex1 + complex2;
            ComplexClass multi = complex1 * complex2;
            ComplexClass sub = complex1 - complex2;
            ComplexClass dev = complex1 / complex2;

            Console.WriteLine("Сумма комплексный чисел " + sum);
            Console.WriteLine("Разность комплексный чисел " + sub);
            Console.WriteLine("Произведение комплексный чисел " + multi);
            Console.WriteLine("Частное комплексный чисел " + dev);
            Console.WriteLine("Комплексное число №1 == Комплексное число№2: {0}", complex1 == complex2);
            Console.WriteLine("Комплексное число №1 != Комплексное число№2: {0}", complex1 != complex2);


            Console.WriteLine("Модуль комплексного числа №1: " + complex1.Abs);
            Console.WriteLine("Модуль комплексного числа №2: " + complex2.Abs);

            Console.WriteLine("Аргумент комплексного числа №1 в градусах: " + complex1.Arg);
            Console.WriteLine("Аргумент комплексного числа №2 в градусах: " + complex2.Arg);

            Console.WriteLine("Нажмите Enter для продолжения...");
            Console.ReadKey();

            Console.WriteLine("   ");

            Console.Write("Введите модуль комплексного числа: ");
            double mod1 = Double.Parse(Console.ReadLine());
            Console.Write("Аргумент комплексного числа: ");
            double arg1 = Double.Parse(Console.ReadLine());
            ComplexClass ComplexComplete = ComplexClass.GetComplex(mod1, arg1);



            Console.WriteLine("Ваше комплексное число: " + ComplexComplete);

            Console.WriteLine("Нажмите Enter для завершения.");
            Console.ReadKey();
        }
    }
}
