namespace Patterns.Structural.Proxy
{
    /// <summary>
    ///     Класс, который создает, управляет и контролирует доступ к субъекту
    /// </summary>
    internal class Proxy : ISubject
    {
        private Subject subject;

        public object Request()
        {
            // Виртуальный прокси создает объект только, когда первый раз вызывается его объект
            if (subject == null)
            {
                subject = new Subject();
            }
            return subject.Request();
        }

        //Метод протекшен прокси
        public string Authenticate(string supplied)
        {
            if (supplied == "")
            {
                subject = new Subject();
            }
            else
            {
                return "Protection Proxy: No access";
            }
            return "Protection Proxy: Authenticated";
        }
    }
}