Console.WriteLine("Say hello to collection expressions!");

//old way
var oldArray = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var oldList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//with collection expression
int[] numberArray = [1, 2, 3, 4, 5, 6, 7, 8, 9];

List<string> numberList = ["one", "two", "three"];

Span<char> numberSpan = ['a', 'b', 'c', 'd', 'e', 'f', 'h', 'i'];

// Create a jagged 2D array:
int[][] twoD = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

// Create a jagged 2D array from variables:
int[] row0 = [1, 2, 3];
int[] row1 = [4, 5, 6];
int[] row2 = [7, 8, 9];
int[][] twoDFromVariables = [row0, row1, row2];