string[] lines = File.ReadAllLines("Day3.txt");
long totalSum = 0;

foreach (string line in lines)
{
    List <int> joltages = new List<int> ();
    foreach (char c in line)
    {
        if(char.IsDigit(c)) joltages.Add(c - '0');
    }

    int maxDigit = joltages[0];
    int indexOfMaxDigit = 0;
    int count = 11;
    string outPut = "";

    while(count >= 0)
    {
        for (int i = 0; i < joltages.Count - count; i++)
        {
            if(joltages[i] > maxDigit) 
            {
                maxDigit = joltages[i];
                indexOfMaxDigit = i;
            }
        }
        outPut +=  maxDigit.ToString();
        maxDigit = 0;
        joltages.RemoveRange(0, indexOfMaxDigit + 1);
        count--;
    }
    totalSum += long.Parse(outPut);
}
Console.WriteLine(totalSum);
