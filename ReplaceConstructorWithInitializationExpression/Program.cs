using ReplaceConstructorWithInitializationExpression;

var Z0 = new Complex(1, 0.1);
var Z1 = Z0 * Z0 + 
         new Complex(1, 0.1);
var Z2 = Z1 * Z1 +
        new Complex(1, 0.1);

Console.WriteLine($"Z2 = {Z2}");