//Add a boarder of '.' to make iteration simpler

string[] linesOfFile = File.ReadAllLines("Day4.txt");

int cols = linesOfFile[0].Length;
int rows = linesOfFile.Length;
string border = new string('.', cols + 2);

string[] result = new string[rows + 2];
result[0] = border;
result[rows + 1] = border;

for (int i = 0; i < rows; i++)
{
    result[i + 1] = "." + linesOfFile[i] + ".";
}

File.WriteAllLines("Day4.txt", result);


List<string> lines = File.ReadAllLines("Day4.txt").ToList();
int totalCount = 0;

char[][] grid = lines
    .Select(line => line.ToCharArray())
    .ToArray();


bool moreToBeFound = true;
while (moreToBeFound)
{
    int originalCount = totalCount;
    for(int row = 1; row < grid.Length - 1; row++)
    {
        //Every element excluding first and last
        for(int col = 1; col < grid[0].Length - 1; col++)
        {
            if(grid[row][col] == '@')
            {
                int count = 0;
                if(grid[row][col + 1] =='@') count++;
                if(grid[row][col - 1] =='@') count++;
                if(grid[row + 1][col + 1] =='@') count++;
                if(grid[row + 1][col] =='@') count++;
                if(grid[row + 1][col - 1] =='@') count++;
                if(grid[row - 1][col + 1] =='@') count++;
                if(grid[row - 1][col] =='@') count++;
                if(grid[row - 1][col - 1] =='@') count++;

                if(count < 4) 
                {
                    totalCount++;
                    grid[row][col] = 'x';
                }
            }
        }
    }

    if(originalCount == totalCount) moreToBeFound = false;
}
Console.WriteLine(totalCount);







    

    







