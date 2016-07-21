namespace Patterns.Structural.Composite
{
    /// <summary>
    ///     Определяет операции, которые имеют смысл и для компонентов и для композитов (например, для файлов и для каталогов).
    /// </summary>
    internal interface IComponent
    {
        void Operation();
    }
}