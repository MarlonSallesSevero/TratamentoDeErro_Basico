using System;
using CriandoExcessoes.Entities;
using CriandoExcessoes.Entities.Exceptions;

namespace CriandoExcessoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initial = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine());
                Account conta = new Account(n, holder, initial, limit);
                Console.WriteLine("*******CONTA CRIADA COM SUCESSO******");
                Console.WriteLine(conta);
                Console.WriteLine("-----------------------------------------------------------");
                Console.Write("Enter amount for withdraw:");
                double am = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------");
                conta.Saque(am);
                Console.WriteLine($"New balance: {conta.Balance}");
            }
            catch (DomainException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                string a = Console.ReadLine();
            }
        }
    }
}
