
using Share;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    Console.WriteLine("Ingrese 3 números enteros para comparar cual es el mayor");
    var number1 = ConsoleExtension.GetInt("Ingrese primer número:");
    var number2 = ConsoleExtension.GetInt("Ingrese segundo número:");
    var number3 = ConsoleExtension.GetInt("Ingrese tercer número:");

    if (number1 > number2 && number1 > number3)
    {
        Console.WriteLine($"El número {number1} es el mayor.");
    }
    else if (number2 > number1 && number2 > number3)
    {
        Console.WriteLine($"El número {number2} es el mayor.");
    }
    else if (number3 > number1 && number3 > number2)
    {
        Console.WriteLine($"El número {number3} es el mayor.");
    }



    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar [S]i , [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game over");