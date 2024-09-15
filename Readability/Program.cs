
Console.Write("Text: ");
string tested_text = Console.ReadLine();

//Declare and initialize word, sentence, and letter count
int w = 0;
int s = 1;
int l = 0;

//Parse content
foreach (char character in tested_text) 
{
    if (character == ' ') 
    {
        w++;
    }
    else if (character == '.' || character is '!' || character is '?') 
    {
        s++;
    }
    else if (char.IsLetterOrDigit(character)) 
    {
        l++;
    }
}

l = (l * 100) / w;
s = (s * 100) / w;
int gradelevel = (int)Math.Round(0.0588 * l - 0.296 * s - 15.8);

if (gradelevel < 1) 
{
    Console.WriteLine("Before Grade 1");
}
else if (gradelevel >= 16)
{
    Console.WriteLine("Grade 16+");
}
else
{
    Console.WriteLine($"Grade {gradelevel}");
}