using Share;
var answer = string.Empty;
var options = new List<string> { "si", "no" };

do
{
    var name = ConsoleExtension.GetString("ingrese su nombre ");
    var lastName = ConsoleExtension.GetString("ingrese su apellido ");

    var H_Work = ConsoleExtension.GetFloat("ingrese las horas trabajadas ");

    var V_hour = ConsoleExtension.GetDecimal("ingrese el valor por hora ");

    var min_salary = ConsoleExtension.GetDecimal("ingrese el salario minimo legal vigente ");


    var salary = (decimal)H_Work * V_hour;   

    if (min_salary >= salary)
    {
        Console.WriteLine($"nombre  .... :{name} {lastName}");
        Console.WriteLine($"salario .... :{salary:C2}");
    }
    else
    {
        Console.WriteLine($"nombre  .... :{name} {lastName}");
        Console.WriteLine($"salario .... :{min_salary:C2}");

    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar [S]i , [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("si", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Amen");
