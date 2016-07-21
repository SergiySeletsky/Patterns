using System;

namespace Patterns.Architectural.Archetype
{
    public class RequestFactory
    {
        public static Request getRequest(String a, String b)
        {
            DecoratorRequest dcr = null;
            DelegateRequest dlr = null;

            if (a.Equals("A"))
                dcr = new ADecoratorRequest();

            if (a.Equals("B"))
                dcr = new BDecoratorRequest();

            if (b.Equals("Y"))
                dlr = new YDelegateRequest();

            if (b.Equals("Z"))
                dlr = new ZDelegateRequest();

            //dcr.setDelegate(dlr);
            return dcr;
        }
    }
}