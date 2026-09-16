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
            bankacc acc = new bankacc(12, "сберегательный", 12000.50);
            Console.WriteLine($"Номер счета:{acc.Number}, тип:{acc.Type}, баланс:{acc.Balance}");

            Console.WriteLine("\nДомашнее задание 3.1");
            worker firstworker = new worker("Сергей", UNI.KAI);
            Console.WriteLine($"Имя работника: {firstworker.Name}, id места работы: {(int)firstworker.Workplace}");




        }
    }
}
