using Share;

var answer = string.Empty;
var options = new List<string> { "si", "no" };

do
{
    var Num_desks = ConsoleExtension.GetInt("Ingrese el numero de escritorios a comprar: ");

    var Pay_total = CalculateValue(Num_desks);
    Console.WriteLine($"El valor total a pagar es: {Pay_total:C2}");



    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar si , no?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

decimal CalculateValue(int Num_desks)
{
    float discount = 0f;
    if (Num_desks < 5)
    {
        discount = 0.1f;
    }
    else if (Num_desks >= 10)
    {
        discount = 0.2f;
    }
    else
    {
        discount = 0.4f;
    }

    return Num_desks * 650000M * (decimal)(1 - discount);

}

Console.WriteLine("Excelente");
