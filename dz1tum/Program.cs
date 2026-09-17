using System;
using dz1tum.stren;

namespace dz1tum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3.1");
            Console.WriteLine($"Номер текущего аккаунта: {(int)bank.Bankacccurr},сберегательного: {(int)bank.Bankaccsave}");

            Console.WriteLine("\nУпражнение 3.2");
            bankacc acc = new bankacc();
            Console.WriteLine("Введите номер счета:");
            acc.Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите тип счета:");
            acc.Type = Console.ReadLine();
            Console.WriteLine("Введите баланс счета:");
            acc.Balance = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Номер счета:{acc.Number}, тип:{acc.Type}, баланс:{acc.Balance}");

            Console.WriteLine("\nДомашнее задание 3.1");
            worker firstworker = new worker();
            Console.WriteLine("Введите имя работника");
            firstworker.Name = Console.ReadLine();
            Console.WriteLine("Введите id  работника");
            firstworker.Workplace =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine($"Имя работника: {firstworker.Name}, id места работы: {(int)firstworker.Workplace}");




        }
    }
}
