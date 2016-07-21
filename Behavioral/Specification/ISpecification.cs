namespace Patterns.Behavioral.Specification
{
    public interface ISpecification<TEntity>
    {
        bool IsSatisfiedBy(TEntity entity);
    }
}