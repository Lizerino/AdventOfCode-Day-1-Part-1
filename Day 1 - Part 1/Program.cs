// Get depths
string[] depths = System.IO.File.ReadAllLines(@"Input.txt");

// Init counter
int deeper = 0;

// Compare each depth with previous depth
// if deeper thatn first depth add 1 to counter else continue
for (int i = 1; i < depths.Length; i++)
{
    if (int.Parse(depths[i])> int.Parse(depths[i-1]))
    {
        deeper++;
    }
}

// print result
Console.WriteLine(deeper);
