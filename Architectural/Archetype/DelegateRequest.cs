using System;

namespace Patterns.Architectural.Archetype
{
    public abstract class DelegateRequest : Request
    {
        public void sendRequest(DelegateRequest a)
        {
            throw new NotImplementedException();
        }

        public void sendRequest()
        {
            throw new NotImplementedException();
        }
    }
}