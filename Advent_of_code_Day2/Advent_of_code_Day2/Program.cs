bool IsRepeated(long n)
{
    string s = n.ToString();
    int L = s.Length;

    for (int len = 1; len <= L / 2; len++)
    {
        if (L % len != 0) continue;

        string segment = s.Substring(0, len);
        bool ok = true;

        for (int i = len; i < L; i += len)
        {
            if (s.Substring(i, len) != segment)
            {
                ok = false;
                break;
            }
        }

        if (ok) return true;
    }
    return false;
}

string text = File.ReadAllText("Day2.txt");
string[] IDs = text.Split(',');

long totalSum = 0;

foreach (string s in IDs)
{
    string[] parts = s.Split('-');
    long start = long.Parse(parts[0]);
    long end = long.Parse(parts[1]);

    for (long n = start; n <= end; n++)
    {
        if (IsRepeated(n))
            totalSum += n;
    }
}

Console.WriteLine(totalSum);


