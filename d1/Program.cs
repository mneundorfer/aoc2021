IEnumerable<string> input = File.ReadLines(@"input.txt");

int? previous = null;
int increased = 0;
foreach (string line in input)
{
    int x = Int32.Parse(line);
    if (previous != null && x > previous)
    {
        increased++;
    }
    previous = x;
}

Console.WriteLine($"pt1: {increased}");

IEnumerable<int> inputsAsInts = input.Select(Int32.Parse);
var previousThreeWindowItemSum = inputsAsInts.Take(3).Sum();
int increasedWindows = 0;

for (int i = 0; i < input.Count(); i++)
{
    var currentThreeItemWindowSum = inputsAsInts.Skip(i).Take(3).Sum();
    if (currentThreeItemWindowSum > previousThreeWindowItemSum)
    {
        increasedWindows++;
    }
    previousThreeWindowItemSum = currentThreeItemWindowSum;

}

Console.WriteLine($"pt2: {increasedWindows}");
