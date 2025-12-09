//Day 1
List <string> lines = File.ReadAllLines("Day_1.txt").ToList();
int count = 0;
int startingPosition = 50;

foreach (string line in lines)
{
    int turns = Int32.Parse(line.Substring(1));

    int fullRotations = turns / 100;
    int partialRotation = turns % 100;

    Console.WriteLine($"{fullRotations}, {partialRotation} ");

    if (line[0] == 'R')
    {
        if(startingPosition + partialRotation > 100 && startingPosition != 0)
        {
            count ++;
            startingPosition = (startingPosition + partialRotation) % 100;
        }
        else if(startingPosition + partialRotation > 100)
        {
            startingPosition = (startingPosition + partialRotation) % 100;
        }
        else
        {
            startingPosition += partialRotation;
        }
    }
    else
    {
        if(startingPosition - partialRotation < 0 && startingPosition != 0)
        {
            count ++;
            startingPosition = 100 + (startingPosition - partialRotation);
        }
        else if(startingPosition - partialRotation < 0)
        {
            startingPosition = 100 + (startingPosition - partialRotation);
        }
        else
        {
            startingPosition -= partialRotation;
        }
    }
    if (startingPosition == 0 || startingPosition == 100) 
    {
        count ++;
        if(startingPosition == 100) startingPosition = 0;
    }
    count += fullRotations;
    Console.WriteLine($"Pos {startingPosition} || Count {count}");

}
Console.WriteLine(count);