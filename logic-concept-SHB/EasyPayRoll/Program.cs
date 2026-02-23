using Share;

var answer = string.Empty;
var options = new List<string> { "Si", "No" };

do
{
    var name = ConsoleExtension.GetString("Ingrese nombre......................: ");
    var workHours = ConsoleExtension.GetFloat("Ingrese número de horas trabajadas..: ");
    var hourValue = ConsoleExtension.GetDecimal("Ingrese valor hora..................: ");
    var salaryMinium = ConsoleExtension.GetDecimal("Ingrese valor salario mínimo mensual: ");

    var salary = (decimal)workHours * hourValue;
    if (salary < salaryMinium)
    {
        Console.WriteLine($"Nombre..................: {name}");
        Console.WriteLine($"Salario.................: {salaryMinium:C2}");
    }
    else
    {
        Console.WriteLine($"Nombre..................: {name}");
        Console.WriteLine($"Salario.................: {salary:C2}");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar Si , No?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Perfecto.");
