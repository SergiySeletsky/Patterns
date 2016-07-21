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
if else(user.LogOut)
{

}
if else(user.FirstName.Contains("Sergey"))
{

}
if else(user.LastName.Lenth > 255)
{

}
if else(user.Age > 18 && user.Age < 35)
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

Conditions be loaded or added outside

Actions can be runned in parallel, just make true in .ctor

Chain can be serialized