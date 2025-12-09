using System.Runtime.InteropServices;

string compressed(string userInput)
{
    int total = 0;
    char original = userInput[0];
    string output = "";

    foreach (char ch in userInput)
    {
        if (ch == original) total++;
        else
        {
            output += $"{original}{total} ";
            original = ch;
            total = 1;
        }
    }

    output += $"{original}{total} ";
    
    return output;
}
Console.WriteLine(compressed("AARRRRGGGHH"));