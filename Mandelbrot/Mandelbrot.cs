// Refactorlings by Producore
// © 2025 - All rights reserved

namespace Mandelbrot;

public class Complex(float R, float I)
{
    public float R { get; } = R;
    public float I { get; } = I;

    public Complex Square()
    {
        var ZR = R;
        var ZI = I;
        var ZSquared = new Complex(ZR * ZR - ZI * ZI, ZR * ZI * 2);
        return ZSquared;
    }

    public float AbsoluteSquared()
    {
        var ZR = R;
        var ZI = I;
        return ZI * ZI + ZR * ZR;
    }

    public static Complex Add(Complex Left, Complex Right)
    {
        return new Complex(Right.R + Left.R, Right.I + Left.I);
    }

    public static readonly Complex Zero = new Complex(0f, 0f);
}

public static class Mandelbrot
{
    public static bool TestEscape(Complex P, int M = 100000)
    {
        var S = 0;
        var Z = Complex.Zero;

        do
        {
            Z = Complex.Add(P, Z.Square());

            if (Z.AbsoluteSquared() > 4)
                return true;

            S++;
        } while (S < M);

        return false;
    }
}