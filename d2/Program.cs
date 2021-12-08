IEnumerable<string> input = File.ReadLines(@"input.txt");

int position = 0;
int depth = 0;

foreach (string line in input) {
    string[] vals = line.Split(' ');
    string type = vals[0];
    int amount = Int32.Parse(vals[1]);
    if (type == "forward")
    {
        position += amount;
    }
    else if (type == "down")
    {
        depth += amount;
    }
    else if (type == "up")
    {
        depth -= amount;
    }
}

Console.WriteLine($"pt1: {position * depth}");
