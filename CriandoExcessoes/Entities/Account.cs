using System;
using CriandoExcessoes.Entities.Exceptions;
namespace CriandoExcessoes.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {

        }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Holder = holder; // Holder pode ter qualquer nome

            if (0 > number)
            {
                throw new DomainException("Numero da conta não é valido - Negativos são Invalidos!!!\n" +
                    "Recrie Sua conta");
            }
            else
            {
                Number = number;
            }
            if (0 > balance)
            {
                throw new DomainException($"Montante não é valido - Negativos são Invalidos!!!\n" +
                    $"Recrie Sua conta");
            }
            else
            {
                Balance = balance;

            }
            if (0 > withdrawLimit)
            {
                throw new DomainException("Limite de Saque não é valido - Negativos são Invalidos!!!\n" +
                    $"Recrie Sua conta");
            }
            else if (withdrawLimit > Balance)
            {
                throw new DomainException("Withdraw Limit não pode ser maior que o Balance");
            }
            else
            {
                WithdrawLimit = withdrawLimit;

            }
        }
        public double Deposit(double value)
        {
            if (0 > value)
            {
                throw new DomainException("Valor do deposito deve ser maior que zero!!");
            }
            else
            {
                Balance += value;
            }
            return Balance;
        }

        public double Saque(double valueS)
        {
            if (0 > valueS)
            {
                throw new DomainException("Valor do saque deve ser maior que zero!!");
            }
            else if (valueS > WithdrawLimit)
            {
                throw new DomainException("O Saque nao pode ser maior que o limite disponivel!!");
            }
            else
            {
                Balance -= valueS;
            }
            return Balance;
        }

        public override string ToString()
        {
            return $"Nº {Number} - Holder : {Holder}\nBALANCE: {Balance}\nWithdraw Limit: {WithdrawLimit}";
        }
    }
}
