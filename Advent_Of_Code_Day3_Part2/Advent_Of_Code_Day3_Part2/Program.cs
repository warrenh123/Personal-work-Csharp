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
    int count = 0;
    string outPut = "";

    
    for (int i = 0; i < joltages.Count - 12; i++)
    {
        if(joltages[i] > maxDigit) 
        {
            maxDigit = joltages[i];
            indexOfMaxDigit = i;
        }
    } 
    outPut +=  maxDigit.ToString();
    joltages.RemoveRange(0, indexOfMaxDigit + 1);

    totalSum += long.Parse(outPut);
    count ++;
    


}
Console.WriteLine(totalSum);
