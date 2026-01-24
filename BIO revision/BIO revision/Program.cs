using System.ComponentModel;

List <long> fibonacci(int n)
{
    List<long> fibonacciSequence = new List<long>{1,2};

    while(true)
    {
        long i = fibonacciSequence.Last() + fibonacciSequence[fibonacciSequence.Count - 2];
        fibonacciSequence.Add(i);
        if(i > n) break;
    }

    
    return fibonacciSequence;
}