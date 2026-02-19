using Share;
var answer = string.Empty;
var options = new List<string> { "si", "no" };
{
    var a = ConsoleExtension.GetInt("Ingrese el primer numero: ");
    var b = ConsoleExtension.GetInt("Ingrese el segundo numero: ");
    if (b % a == 0)
    {
        Console.WriteLine($"{a} es multiplo de {b}");
    }
    else
    {
        Console.WriteLine($"{a} no  es multiplo de {b}");

    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar Si , No?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
