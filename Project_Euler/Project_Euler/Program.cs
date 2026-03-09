// Question 3: Largest prime factor
/*
long n = 600851475143;
long factor = 2;
long largest = 0;

while (factor * factor <= n)
{
    if (n % factor == 0)
    {
        largest = factor;
        n /= factor;
    }
    else
    {
        factor++;
    }
}

if (n > 1)
    largest = n;

Console.WriteLine(largest);
*/
// Question 4: Largest palindrome 

bool found = false;
int i = 999;
int j = 999;

while(found = false)
{
    List<char> chars = new List<char>{};
    bool comparison = true;

    int product = i * j;
    string s = product.ToString();
    foreach(char c in s) chars.Add(c);
    
    if (chars.Count % 2 == 0)
    {
        int partsLengthEven  = chars.Count / 2;
        for(int i = 0, j = chars.Count - 1; i < partsLengthEven; i++, j--)
        {
            if(chars[i] != chars[j]) comparison = false;
        }
    }
    else if (chars.Count % 2 == 1)
    {
        int prtsLengthOdd = (chars.Count - 1) / 2;
        for (int i = 0, j = chars.Count - 1; i < partslengthOdd; i++, j--)
        {
            if(chars[i] != chars[j]) comparison = false;
        }
    }

    if(comparison == true)
    {
        Console.WriteLine(product);
        found = true;
    }

    //need nested loop so i and j can change at different rates
    
}