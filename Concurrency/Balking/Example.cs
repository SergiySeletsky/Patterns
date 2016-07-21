namespace Patterns.Concurrency.Balking
{
    public class Example
    {
        private bool jobInProgress;

        public void job()
        {
            lock (this)
            {
                if (jobInProgress)
                {
                    return;
                }
                jobInProgress = true;
            }
            // Code to execute job goes here
            // ...
        }

        private void jobCompleted()
        {
            lock (this)
            {
                jobInProgress = false;
            }
        }
    }
}