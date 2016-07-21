using System;

namespace Patterns.Architectural.Archetype
{
    public class App
    {
        public static void main(String[] args)
        {
            Request cr = null;

            cr = RequestFactory.getRequest("A", "Y");
            cr.sendRequest(null);

            cr = RequestFactory.getRequest("A", "Z");
            cr.sendRequest(null);

            cr = RequestFactory.getRequest("B", "Y");
            cr.sendRequest(null);

            cr = RequestFactory.getRequest("B", "Z");
            cr.sendRequest(null);
        }
    }
}