using Refactorlings;

var Point = new Complex(.1, .1);
var Z0 = Point;
var Z1 = Z0 * Z0 + Point;
var Z2 = Z1 * Z1 + Point;

Console.WriteLine($"Z2 = {Z2}");