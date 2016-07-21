namespace Patterns.Structural.Proxy
{
    /// <summary>
    ///     Общий интерфейс субъектов, к которым осуществляется доступ, и прокси-объектов. Это дает возможность использовать их взаимозаменяемым образом.
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        ///     Операция субъекта, которая доступна клиенту через прокси
        /// </summary>
        /// <returns></returns>
        object Request();
    }
}