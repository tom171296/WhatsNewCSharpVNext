
var preCSharp12 = new int[] { 1, 2, 3, 4, 5 }; // array initializer

// Make the type explicit
int[] cSharp12 = [ 1, 2, 3, 4, 5 ]; 
int[][] twoD = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

int[] row0 = [1, 2, 3];
int[] row1 = [4, 5, 6];
int[] row2 = [..row0, ..row1, 7, 8, 9]; // spread element

row0[0] = 10;

foreach (var element in row2)
{
    Console.Write($"{element}, ");
}

foreach (var element in row0)
{
    Console.Write($"{element}, ");
}

// use it for initialization of private fields
// private static readonly ImmutableArray<string> _months = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];


// var test = [1, 2, 3, 4, 5];