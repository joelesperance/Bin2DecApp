Console.WriteLine("--------BINARY TO DECIMAL CONVERTER--------");
Console.WriteLine("------------[Type quit to exit]------------\n");
string binary = "";

while (binary.ToLower() != "quit")
{
    Console.Write("Enter a Binary Number: ");
    binary = Console.ReadLine();

    int decimalNum = 0;
    bool binaryIsValid = false;

    foreach (char i in binary)
    {
        if (i == '0' || i == '1')
        {
            binaryIsValid = true;
        }
        else
        {
            binaryIsValid = false;
            break;
        }
    }

    if (binaryIsValid)
    {
        foreach (char i in binary)
        {
            decimalNum = decimalNum * 2 + (i - 48);
        }
        Console.WriteLine($"\nDecimal: {decimalNum}\n");
    }
    else if (binary == "quit")
    {
        Console.WriteLine("\nGoodbye!\n");
    }
    else
    {
        Console.WriteLine("\nInvalid input\n");
    }
}



