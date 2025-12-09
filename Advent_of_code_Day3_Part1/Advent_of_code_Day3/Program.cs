string[] lines = File.ReadAllLines("Day3.txt");
int totalSum = 0;

foreach (string line in lines)
{
    List <int> joltages = new List<int> ();
    foreach (char c in line)
    {
        if(char.IsDigit(c)) joltages.Add(c - '0');
    }

    int maxDigit1 = joltages[0];
    int indexOfMaxDigit1 = 0;

    for (int i = 0; i < joltages.Count; i++)
    {
        if(joltages[i] > maxDigit1) 
        {
            maxDigit1 = joltages[i];
            indexOfMaxDigit1 = i;
        }
    } 

    if (indexOfMaxDigit1 == joltages.Count - 1 && joltages.Count > 1)
    {
        joltages.RemoveAt(joltages.Count - 1);

        maxDigit1 = joltages[0];
        indexOfMaxDigit1 = 0;

        for (int k = 0; k < joltages.Count; k++)
        {
            if(joltages[k] > maxDigit1) 
            {
                maxDigit1 = joltages[k];
                indexOfMaxDigit1 = k;
            }
        } 
    }
    Console.WriteLine($"maxdigit1: {maxDigit1}");

    List <int> joltages2 = new List<int> ();
    foreach (char c in line)
    {
        if(char.IsDigit(c)) joltages2.Add(c - '0');
    }

    int maxDigit2 = joltages2[indexOfMaxDigit1 + 1];

    for (int j = indexOfMaxDigit1 + 1; j < joltages2.Count; j++)
    {
        if(joltages2[j] > maxDigit2)
        {
            maxDigit2 = joltages2[j];
        }
    }
    Console.WriteLine($"maxdigit2: {maxDigit2}");

    totalSum += int.Parse($"{maxDigit1}{maxDigit2}");
    Console.WriteLine($"{maxDigit1}{maxDigit2}");
}
Console.WriteLine(totalSum);
