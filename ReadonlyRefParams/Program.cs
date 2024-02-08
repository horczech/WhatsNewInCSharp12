//Note:
// - when you need to pass readonly value type
// - used to prevent breaking changes when migrating older APIs that were introduced before in parameters existed (and therefore used ref)

using System;

var readOnlyValueType = 22;

var example = new Example();
example.Test(ref readOnlyValueType);


public class Example
{
    public void Test(ref readonly int readOnlyValueType) {
        Console.WriteLine("In method");
    }
}
