Console.WriteLine("Say hello to ref readonly parameters!");

//Note:
// - you need to pass readonly value type
// - used to prevent breaking changes when migrating older APIs that were introduced before in parameters existed (and therefore used ref)

var readOnlyValueType = 22;

var example = new Example();

Console.WriteLine($"Before: {readOnlyValueType}");
example.Test(ref readOnlyValueType);
Console.WriteLine($"After: {readOnlyValueType}");


public class Example
{
    public void Test(ref readonly int readOnlyValueType) {
        Console.WriteLine("In method");
        //readOnlyValueType++;
    }

}
