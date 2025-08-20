// See https://aka.ms/new-console-template for more information

using ReplaceConstructorWithInitializationExpression;

var Apple = new Fruit("apple", 4, 19, "it keeps doctors away");
var Orange = new Fruit("orange", 5, 13, "not an apple");
var Banana = new Fruit("banana", 9, 15, "good source of potassium");

if (Compare(Banana, new("Banana", 8, 15, "good source of potassium")))
  Console.Write("They're equal!");
else
  Console.WriteLine("They're not");

Console.WriteLine(Apple);
Console.WriteLine(Orange);

  bool Compare(Fruit Left, Fruit Right)
  {
    if (Left.Name != Right.Name)
      throw new ArgumentException($"Cannot compare {Left.Name} and {Right.Name}");

    return Equals(Left, Right);
  }

