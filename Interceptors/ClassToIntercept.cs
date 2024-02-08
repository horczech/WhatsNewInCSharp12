namespace Interceptors;

public class ClassToIntercept
{
    public void OriginalMethod(string name) {
        Console.WriteLine($"Running original method with name {name}");
    }
}