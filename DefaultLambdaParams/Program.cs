Console.WriteLine("Say hello to default lambda parameters");


var lambda = (int someValue) => $"Some value is: {someValue}";


Console.WriteLine(lambda(22));
