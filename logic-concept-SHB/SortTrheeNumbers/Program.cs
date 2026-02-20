using Share;
var answer = string.Empty;
var options = new List<string> { "si", "no" };

do
{
    var a = ConsoleExtension.GetInt("Ingrese el primer numero: ");
    var b = ConsoleExtension.GetInt("Ingrese el segundo numero: ");
    var c = ConsoleExtension.GetInt("Ingrese el tercer numero: ");

    if (a > b && a > c)
    {
        if (b > c)
        {
            Console.WriteLine($"El mayor es {a} el de el medio es {b} el menor es {c}");

        }
        else
        {
            Console.WriteLine($"El mayor es {a}, el de el medio es {c} el menor es {b}");
        }
    }
    else if (b > a && b > c)
    {
        if (a > c)
        {
            Console.WriteLine($"El mayor es {b} el de el medio es {a} el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El mayor es {b}, el de el medio es {c} el menor es {a}");
        }
    }
    else
    {
        if (a > b)
        {
            Console.WriteLine($"El mayor es {c} el de el medio es {a} el menor es {b}");
        }
        else
        {
            Console.WriteLine($"El mayor es {c}, el de el medio es {b} el menor es {a}");
        }
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar si , no?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("nice");
