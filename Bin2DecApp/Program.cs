Console.WriteLine("--------BINARY TO DECIMAL CONVERTER--------\n");
Console.Write("Enter a Binary Number: ");
string binary = Console.ReadLine();

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
else
{
    Console.WriteLine("\nInvalid input\n");
}

