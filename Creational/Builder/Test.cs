namespace Patterns.Creational.Builder
{
    public class Test
    {
        public void Do()
        {
            var director = new Director();
            IBuilder builder = new Builder();
            director.Construct(builder);
            builder.GetResult();
        }
    }
}