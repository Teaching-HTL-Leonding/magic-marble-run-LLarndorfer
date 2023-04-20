//*Magic Marble Run
//*Lukas Larndorfer 
int segments = 0;
int teleports = 0;
int position = 0;
int indextoteleportto = 0;
Boolean lastdigitbackwards = false;
System.Console.WriteLine("vaaliid");
string input = Console.ReadLine()!;






for (position = 0; position < input.Length;)
{
    if (input[position] == '>')
    {
        segments++;
        position++;
        lastdigitbackwards = false;
    }
    else if (input[position] == '<')
    {
        segments++;
        position--;
        lastdigitbackwards = true;
    }
    else if (Char.IsLetterOrDigit(input[position]))
    {
        if (!lastdigitbackwards)
        {
            if (input[position + 1] == 'x')
            {
                indextoteleportto = int.Parse(input.Substring(position + 2, 4), System.Globalization.NumberStyles.HexNumber);
                position = indextoteleportto;
                teleports++;
            }
            else
            {
                indextoteleportto = int.Parse(input.Substring(position, 4));
                position = indextoteleportto;
                teleports++;
            }

        }
        else
        {
            if (input[position - 4] == 'x')
            {
                indextoteleportto = (int.Parse(input.Substring(position - 4, 4), System.Globalization.NumberStyles.HexNumber));
                position = indextoteleportto;
                teleports++;
            }
            else if (input[position - 3] == 'x')
            {
                indextoteleportto = (int.Parse(input.Substring(position - 3, 4), System.Globalization.NumberStyles.HexNumber));
                position = indextoteleportto;
                teleports++;
            }
            else
            {
                indextoteleportto = int.Parse(input.Substring(position - 3, 4));
                position = indextoteleportto;
                teleports++;
            }
        }
    }
}

Console.WriteLine($"Teleports: {teleports}; Segments: {segments}");