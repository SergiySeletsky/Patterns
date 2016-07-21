namespace Patterns.Behavioral.Visitor
{
    internal abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}