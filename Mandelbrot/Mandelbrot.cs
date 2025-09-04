// Refactorlings by Producore
// © 2025 - All rights reserved

public static class Mandelbrot
{
  public static bool TestEscape(
    float R, float I, int M = 100000)
  {
    float ZR = 0f, ZI = 0f;
    var S = 0;

    do
    {
      var T = ZR * ZR - ZI * ZI;
      ZI = ZR * ZI * 2;
      ZR = T;

      ZR = ZR + R;
      ZI = ZI + I;

      if (ZI * ZI + ZR * ZR > 4)
        return true;

      S++;
    } while (S < M);

    return false;
  }
}