using System;
using System.Numerics;

class SimpleRSA
{
    // Compute gcd
    static int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);

    // Extended Euclidean Algorithm for modular inverse
    static int ModInverse(int e, int phi)
    {
        int t = 0, newt = 1, r = phi, newr = e;
        while (newr != 0)
        {
            int q = r / newr;
            (t, newt) = (newt, t - q * newt);
            (r, newr) = (newr, r - q * newr);
        }
        if (t < 0) t += phi;
        return t;
    }

    // Fast modular exponentiation
    static BigInteger ModPow(BigInteger baseVal, BigInteger exp, BigInteger mod)
    {
        BigInteger result = 1;
        while (exp > 0)
        {
            if ((exp & 1) == 1) result = (result * baseVal) % mod;
            baseVal = (baseVal * baseVal) % mod;
            exp >>= 1;
        }
        return result;
    }

    static void Main()
    {
        int p = 11, q = 13;       // small primes
        int n = p * q;
        int phi = (p - 1) * (q - 1);

        int e = 7;                // choose e coprime with phi
        while (GCD(e, phi) != 1) e++;

        int d = ModInverse(e, phi);

        Console.WriteLine($"p={p}, q={q}, n={n}, phi={phi}, e={e}, d={d}");
        Console.Write("Enter message (int < n): ");
        int m = int.Parse(Console.ReadLine());

        BigInteger c = ModPow(m, e, n);
        Console.WriteLine($"Encrypted: {c}");

        BigInteger decrypted = ModPow(c, d, n);
        Console.WriteLine($"Decrypted: {decrypted}");
    }
}
