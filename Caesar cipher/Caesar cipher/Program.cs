using System.Text;

static string VernamEncrypt(string text, string key)
{
    StringBuilder result = new StringBuilder();

    for (int i = 0; i < text.Length; i++)
    {   
        char encryptedChar = (char)(text[i] ^ key[i]);
        result.Append(encryptedChar);
    }

    return result.ToString();
}
Console.WriteLine(VernamEncrypt("The cat sat on the mat", "It was the best of times it was the worst of times"));

