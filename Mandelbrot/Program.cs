// Refactorlings by Producore
// © 2025 - All rights reserved

Test(-2.001f, 0);
Test(-1.999f, 0);
Test(.249f, 0);
Test(.251f, 0);
Test(0, -.637f);
Test(0, -.635f);
Test(0, .635f);
Test(0, .647f);

void Test(float F, float F1)
{
  var Z = Mandelbrot.TestEscape(new Complex(F, F1));

  Console.WriteLine($"Escape {F}, {F1}: {Z}");
}

var SearchWindow = (.630f, .640f);

do
{
  var TestSpot = (SearchWindow.Item2 -
                  SearchWindow.Item1) /
                 2 + SearchWindow.Item1;

  if (Mandelbrot.TestEscape(new Complex(0, TestSpot)))
    SearchWindow = (SearchWindow.Item1,
      TestSpot);
  else
    SearchWindow = (TestSpot,
      SearchWindow.Item2);

} while(SearchWindow.Item2 - SearchWindow.Item1 > 0.00001f);

Console.WriteLine($"Search Window narrowed to {SearchWindow}");