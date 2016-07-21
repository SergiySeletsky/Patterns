namespace Patterns.Behavioral.Specification
{
    internal class AndSpecification<TEntity> : ISpecification<TEntity>
    {
        private readonly ISpecification<TEntity> Spec1;
        private readonly ISpecification<TEntity> Spec2;

        internal AndSpecification(ISpecification<TEntity> s1, ISpecification<TEntity> s2)
        {
            Spec1 = s1;
            Spec2 = s2;
        }

        public bool IsSatisfiedBy(TEntity candidate)
        {
            return Spec1.IsSatisfiedBy(candidate) && Spec2.IsSatisfiedBy(candidate);
        }
    }
}