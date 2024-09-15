
Console.WriteLine("Let'sa Go! How many blocks?");
int block_count;
bool blocksentered = false;
while (blocksentered == false)
{
    if (int.TryParse(Console.ReadLine(), out block_count))
    {
        if (block_count > 9)
        {
            Console.WriteLine("Mama Mia! Too many!");
        }
        else if (block_count <= 0)
        {
            Console.WriteLine("No, no, no! Too small!");
        }
        else
        {
            blocksentered = true;
            Console.WriteLine("Okay! Here we go!");
            for (int i = 0; i < block_count; i++)
            {
                for (int j = (block_count - i) - 1; j >= 0; j--)
                {
                    Console.Write(" ");
                }
                for (int h = 0; h < i + 1; h++)
                {
                    Console.Write("#");
                }
                Console.Write("  ");
                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
    else
    {
        Console.WriteLine("That's not a number!");
    }
}
