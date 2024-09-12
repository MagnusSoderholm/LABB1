

Console.WriteLine("Mata in en text: ");

string input = Console.ReadLine();

Console.WriteLine("-----------------------------");

ulong sum = 0;

List<string> numbers = new List<string>();

for (int i = 0; i < input.Length; i++)
{
    if (char.IsDigit(input[i]))
    {
        for (int j = i + 1; j < input.Length; j++)
        {
            if (input[j] == input[i])
            {
                string firstLine = input.Substring(0, i);

                string lineNeeded = input.Substring(i, j + 1 - i);

                string lastLine = input.Substring(j + 1);

                Console.Write(firstLine);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(lineNeeded);
                Console.ResetColor();
                Console.WriteLine(lastLine);

                numbers.Add(lineNeeded);

                break;
            }
            else if (!char.IsDigit(input[j]))
            {
                break;
            }

        }
    }
}


foreach (string number in numbers)
{
    sum += ulong.Parse(number);
}

Console.WriteLine("-----------------------------");
Console.WriteLine($"Totalt = {sum}");

