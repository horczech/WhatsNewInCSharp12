Console.WriteLine("Say hello to default lambda parameters");


var lambda = (int someValue = 11) => $"Some value is: {someValue}";


Console.WriteLine(lambda());
