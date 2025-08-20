// MIT License
// 
// Copyright (c) 2025-2025 Producore LLC
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

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