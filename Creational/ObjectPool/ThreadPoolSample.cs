using System.Threading;

namespace Patterns.Creational.ObjectPool
{
    internal class ThreadPoolSample
    {
        public void Sample()
        {
            ThreadPool.QueueUserWorkItem(x => { });
        }
    }
}