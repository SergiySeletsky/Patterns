namespace Patterns.Concurrency.Lock
{
    internal class Account
    {
        // this is a monitor of an account
        private readonly object thisLock = new object();
        private long val;

        public void Deposit(long x)
        {
            lock (thisLock)
            {
                // only 1 thread at a time may execute this statement
                val += x;
            }
        }

        public void Withdraw(long x
            )
        {
            lock (thisLock)
            {
                val -= x;
            }
        }
    }
}