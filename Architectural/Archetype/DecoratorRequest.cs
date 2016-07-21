namespace Patterns.Architectural.Archetype
{
    public abstract class DecoratorRequest : Request
    {
        protected DelegateRequest a;

        public void sendRequest(DelegateRequest a)
        {
            this.a = a;
        }
    }
}