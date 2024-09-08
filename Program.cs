
using TextFileGenerator;

if (args.Length == 0)
{
    Console.WriteLine("Please provide the number of lines as an argument.");
    Console.WriteLine("Press any key.");
    Console.ReadKey();
    return;
}

if (!int.TryParse(args[0], out int amountOfLines))
{
    Console.WriteLine("Invalid input. Please provide a valid number for the amount of lines.");
    Console.WriteLine("Press any key.");
    Console.ReadKey();
    return;
}

Console.WriteLine("Starting to generating file.");
FileGenerator.GenerateFile(amountOfLines);

Console.WriteLine("File is ready! Thank you for waiting.");
Console.WriteLine("Press any key.");
Console.ReadKey();
