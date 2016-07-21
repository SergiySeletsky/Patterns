using System;

namespace Patterns.Behavioral.State
{
    /// <summary>
    ///     Context - класс, объекты которого должны менять свое поведение в зависимости от состояния, имеет переменную типа IState, которая сначала имеет конкретное состояние.
    /// </summary>
    internal class Account
    {
        private State state;

        public Account()
        {
            state = new SilverState(0.0, this);
        }

        public double Balance
        {
            get { return state.Balance; }
        }

        public State State
        {
            get { return state; }
            set { state = value; }
        }

        public void Deposit(double amount)
        {
            state.Deposit(amount);
            Console.WriteLine("Deposited {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", Balance);
            Console.WriteLine(" Status  = {0}",
                              State.GetType().Name);
            Console.WriteLine("");
        }

        public void Withdraw(double amount)
        {
            state.Withdraw(amount);
            Console.WriteLine("Withdrew {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", Balance);
            Console.WriteLine(" Status  = {0}\n",
                              State.GetType().Name);
        }

        public void PayInterest()
        {
            state.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine(" Balance = {0:C}", Balance);
            Console.WriteLine(" Status  = {0}\n",
                              State.GetType().Name);
        }
    }
}