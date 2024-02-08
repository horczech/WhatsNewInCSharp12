using Interceptors;

//Note:
// - An interceptor is a method that can substitute a call to an interceptable method with a call to itself at compile time.
// - If more than one interceptor refers to the same location, it is a compile-time error.
// 
// 

var example = new ClassToIntercept();

example.OriginalMethod("Method 1");
example.OriginalMethod("Method 2");