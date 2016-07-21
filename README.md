# Patterns
##.NET Patterns by Sergey Seletsky

###My Favorite
###Functional Chain of Responsibility pattern

###Before
```C#
var user = new User();
if(user.HasPassword)
{

}
else if(user.LogOut)
{

}
else if(user.FirstName.Contains("Sergey"))
{

}
else if(user.LastName.Lenth > 255)
{

}
else if(user.Age > 18 && user.Age < 35)
{

} //more...
```
###After
```C#
var chain = new Chain<User> {
    { u => u.HasPassword, u => {  } },
    { u => u.LogOut, u => {  } },
    { u => u.FirstName.Contains("Sergey"), u => { } },
    { u => u.LastName.Lenth > 255, u => {  } },
    { u => u.Age > 18 && u.Age < 35, u => {  } }
	//more conditions...
};

var user = new User();
chain.Process(user);
```
###Benefits

Conditions can be loaded or added outside

Actions can be runned in parallel, just make true in .ctor

Chain can be serialized


###Implementation
```C#
/// <summary>
/// Functional Chain of Responsibility pattern
/// </summary>
/// <typeparam name="T">Type that used in conditions</typeparam>
public class Chain<T> : Dictionary<Predicate<T>, Action<T>>
{
    private readonly bool parallel;

    /// <summary>
    /// Creates instance of functional Chain of Responsibility pattern
    /// </summary>
    /// <param name="parallel">Enable when multiple conditions can be true for one case. It will run true conditions in parallel</param>
    public Chain(bool parallel = false)
    {
        this.parallel = parallel;
    }

    /// <summary>
    /// Find all actions by value used in conditions
    /// </summary>
    /// <param name="value">value used in conditions</param>
    /// <returns>Actions filtered</returns>
    public IEnumerable<Action<T>> Find(T value)
    {
        return this.Where(i => i.Key(value)).Select(i => i.Value);
    }

    /// <summary>
    /// Process all actions
    /// </summary>
    /// <param name="value">Value to find and run actions</param>
    public void Process(T value)
    {
        if (parallel)
        {
            Parallel.ForEach(Find(value), action => action(value));
        }
        else
        {
            foreach (var action in Find(value))
            {
                action(value);
            }
        }
    }
}
```