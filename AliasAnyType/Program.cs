using MyTuple = (int x, int y);
using NullableInt = int?;
using unsafe IntPointer = int*;
using IntArray = int[];

//Note: 
// - up until now C# allowed aliases for namespaces and named types (classes, delegates, interfaces, records and structs)
// - now we can use aliases for any type (tuple , pointer , array , etc.)

var myTuple = new MyTuple(1, 2);

