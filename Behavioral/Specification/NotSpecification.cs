namespace Patterns.Behavioral.Specification
{
    internal class NotSpecification<TEntity> : ISpecification<TEntity>
    {
        private readonly ISpecification<TEntity> Wrapped;

        internal NotSpecification(ISpecification<TEntity> x)
        {
            Wrapped = x;
        }

        public bool IsSatisfiedBy(TEntity candidate)
        {
            return !Wrapped.IsSatisfiedBy(candidate);
        }
    }
}