using Share;
var answer = string.Empty;
var options = new List<string> { "si", "no" };
do
{
    var currentYear = DateTime.Now.Year;
    var message = string.Empty;
    var year = ConsoleExtension.GetInt("Ingrese ano: ");

    
    if (year == currentYear)
    {
        message = "es";
    }
    else if (year > currentYear)
    {
        message = "sera";
    }
    else
    {
        message = "fue";
    }




    if (year % 4 == 0)

    {
        if (year % 100 == 0)
        {
            if (year % 400 == 0)

            {
                Console.WriteLine($"el  {year}  Si {message} biciesto");
            }
            else
            { 
                Console.WriteLine($"el  {year} no {message} biciesto");
            }

        }
        else
        {
            Console.WriteLine($"el  {year} Si {message} biciesto");
        }




    }
    else
    {
        Console.WriteLine($"el  {year} no {message} biciesto");
    }



    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar si , no?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("si", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Super excelente");