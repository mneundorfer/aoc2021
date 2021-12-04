int? previous = null;
int increased = 0;
foreach (string line in File.ReadLines(@"input.txt"))
{
    int x = Int32.Parse(line);
    if (previous != null && x > previous) {
        increased++;
    }
    previous = x;
}

Console.WriteLine(increased);
