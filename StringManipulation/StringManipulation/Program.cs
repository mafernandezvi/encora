// See https://aka.ms/new-console-template for more information
using StringManipulation;

Console.WriteLine("Hello, World!");

int? quantity = null;

while(quantity == null)
{
    Console.WriteLine("Insert the number of strings to be processed.");
    string? quantityText = Console.ReadLine();
    int tmpQuantity = 0;
    bool isValid = int.TryParse(quantityText, out tmpQuantity);
    if(isValid) quantity = tmpQuantity;
}

int counter = 0;
string[] stringArray = new string[quantity.Value];

while (counter < quantity)
{
    Console.WriteLine($"{ counter + 1} of { quantity } strings. Empty, numbers and null are not valid values.");
    string? text = Console.ReadLine();
    if(!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text.Trim()) && !text.Any(x=> char.IsDigit(x)))
    {
        stringArray[counter] = text.Trim();
        counter++;
    }
}

Console.WriteLine("Result:");

var results = ProcessStrings.SortingOperations(stringArray);
foreach (var result in results)
{
    Console.WriteLine(result);
}

Console.ReadKey();
