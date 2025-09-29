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
  var Z = Mandelbrot.TestEscape(F, F1);

  Console.WriteLine($"Escape {F}, {F1}: {Z}");
}