//Note:
// - enables to create an array of fixed size in a struct type
// - inline buffer should provide performance characteristics similar to an unsafe fixed size buffer

var buffer = new FixedSizeBuffer();
buffer[0] = 1;


[System.Runtime.CompilerServices.InlineArray(10)]
public struct FixedSizeBuffer
{
    private int _value;
}


//old way
public unsafe struct OldFixedSizeBuffer
{
    public fixed int MyBuffer[10]; // Fixed-size buffer of 10 integers
}