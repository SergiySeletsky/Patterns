namespace Patterns.Behavioral.State
{
    /// <summary>
    ///     IState - интерфейс, который реализуют все состояния, содержит объект класса Context, поведение которого нужно будет изменить. Это необходимо для того, чтобы в процессе выполнения программы заменять объект состояния при появлении запроса.
    /// </summary>
    internal abstract class State
    {
        protected Account account;
        protected double balance;
        protected double interest;
        protected double lowerLimit;
        protected double upperLimit;

        public Account Account
        {
            get { return account; }
            set { account = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void PayInterest();
    }
}