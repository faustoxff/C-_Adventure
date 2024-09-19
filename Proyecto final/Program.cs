using System;

class Program
{
    static void Main(string[] args)
    {
        Capitulo1();
        
    }

    static void Capitulo1()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("                     Capitulo 1: La Mision                 ");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.ResetColor();

        Console.WriteLine("El rey te ordena rescatar a la princesa Elena,");
        Console.WriteLine("prisionera de un dragon en una torre lejana");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("                /\\        /\\  ");
        Console.WriteLine("               /  \\______/  \\ ");
        Console.WriteLine("              /               \\ ");
        Console.WriteLine("             /_________________\\");
        Console.WriteLine("            |  __   __   __   __|");
        Console.WriteLine("            | |__| |__| |__| |__|");
        Console.WriteLine("            |___________________|");
        Console.ResetColor();

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Que decides hacer");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("1. Vas directo a enfrentarte al dragon (Ir al Capitulo 2A)");
        Console.WriteLine("2. Buscas una forma de negociar con el dragon (Ir al Capitulo 2B)");
        Console.WriteLine();

        Console.Write("Elige una opcion (1 o 2): ");
        string eleccion = Console.ReadLine();

        if (eleccion == "1")
        {
            Console.Clear();
            Console.WriteLine("Has decidido enfrentarte al dragon directamente");
            Console.WriteLine("Buena suerte caballero valiente (Ir al Capitulo 2A)");
            Capitulo2A();
        }
        else if (eleccion == "2")
        {
            Console.Clear();
            Console.WriteLine("Has decidido negociar con el dragon");
            Console.WriteLine("Quizas la diplomacia te lleve a buen puerto (Ir al Capitulo 2B)");
            Capitulo2B();
        }
        else
        {
            Console.WriteLine("Opcion invalida Por favor elige 1 o 2");
        }
    }

    static void Capitulo2A()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("                     Capitulo 2A: El Combate               ");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.ResetColor();

        Console.WriteLine("Te enfrentas al dragon en un combate feroz");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("              / \\__/\\   ");
        Console.WriteLine("             /  o  o \\  ");
        Console.WriteLine("            |    <>    |");
        Console.WriteLine("             \\  __  /  ");
        Console.WriteLine("              |__|");
        Console.ResetColor();

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Que decides hacer");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("1. Lo derrotas y corres a rescatar a la princesa (Ir al Capitulo 3A)");
        Console.WriteLine("2. El dragon te vence y caes en combate (Final 1: Mueres y la princesa queda atrapada)");
        Console.WriteLine();

        Console.Write("Elige una opcion (1 o 2): ");
        string eleccion = Console.ReadLine();

        if (eleccion == "1")
        {
            Console.Clear();
            Console.WriteLine("Has derrotado al dragon y corres a rescatar a la princesa");
            Console.WriteLine("La aventura continua (Ir al Capitulo 3A)");
            Capitulo3A();
        }
        else if (eleccion == "2")
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("El dragon te ha vencido Has caido en combate");
            Console.WriteLine("Final 1: Mueres y la princesa queda atrapada");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Opcion invalida Por favor elige 1 o 2");
        }
    }

    static void Capitulo2B()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("                     Capitulo 2B: La Negociacion          ");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.ResetColor();

        Console.WriteLine("Intentas negociar con el dragon");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("          /\\_/\\  ");
        Console.WriteLine("         ( o.o ) ");
        Console.WriteLine("          > ^ <  ");
        Console.ResetColor();

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Que decides hacer");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("1. Ofreces algo valioso al dragon a cambio de la princesa (Ir al Capitulo 3C)");
        Console.WriteLine("2. Atacas al dragon por sorpresa durante la negociacion (Ir al Capitulo 3D)");
        Console.WriteLine();

        Console.Write("Elige una opcion (1 o 2): ");
        string eleccion = Console.ReadLine();

        if (eleccion == "1")
        {
            Console.Clear();
            Console.WriteLine("Has ofrecido algo valioso al dragon");
            Console.WriteLine("La aventura continua (Ir al Capitulo 3C)");
            Capitulo3C();
        }
        else if (eleccion == "2")
        {
            Console.Clear();
            Console.WriteLine("Atacas al dragon durante la negociacion");
            Console.WriteLine("La aventura continua (Ir al Capitulo 3D)");
            Capitulo3D();
        }
        else
        {
            Console.WriteLine("Opcion invalida Por favor elige 1 o 2");
        }
    }

    static void Capitulo3A()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("                     Capitulo 3A: El Rescate              ");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.ResetColor();

        Console.WriteLine("Encuentras a la princesa pero la torre empieza a colapsar");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("       ____||____       ");
        Console.WriteLine("      ///////////\\      ");
        Console.WriteLine("     ///////////  \\     ");
        Console.WriteLine("    ///////////____\\    ");
        Console.WriteLine("   ///////////|    |\\   ");
        Console.WriteLine("  /////////// |____| \\  ");
        Console.ResetColor();

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Que decides hacer");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("1. Escapan juntos justo a tiempo (Final 3: Ambos sobreviven)");
        Console.WriteLine("2. Te quedas para asegurar su escape sacrificandote (Final 4: Tu mueres pero la princesa escapa)");
        Console.WriteLine();

        Console.Write("Elige una opcion (1 o 2): ");
        string eleccion = Console.ReadLine();

        if (eleccion == "1")
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Escapan juntos justo a tiempo");
            Console.WriteLine("Final 3: Ambos sobreviven");
            Console.ResetColor();
        }
        else if (eleccion == "2")
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Te quedas para asegurar el escape de la princesa");
            Console.WriteLine("Final 4: Tu mueres pero la princesa escapa");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Opcion invalida Por favor elige 1 o 2");
        }
    }

    static void Capitulo3B()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("                     Capitulo 3B: La Traicion Fallida     ");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.ResetColor();

        Console.WriteLine("Tu ataque sorpresa falla y el dragon enfurecido te ataca");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("            /\\_/\\   ");
        Console.WriteLine("           ( o.o ) ");
        Console.WriteLine("            > ^ <  ");
        Console.WriteLine("             /\\   ");
        Console.WriteLine("            /  \\  ");
        Console.WriteLine("           /____\\ ");
        Console.ResetColor();

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Que decides hacer");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("1. Te enfrentas al dragon en una batalla epica (Final 9: Sobrevives con la princesa)");
        Console.WriteLine("2. Intentas huir pero el dragon te alcanza (Final 10: El dragon te captura)");
        Console.WriteLine();

        Console.Write("Elige una opcion (1 o 2): ");
        string eleccion = Console.ReadLine();

        if (eleccion == "1")
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Te enfrentas al dragon en una batalla epica");
            Console.WriteLine("Final 9: Sobrevives con la princesa");
            Console.ResetColor();
        }
        else if (eleccion == "2")
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Intentas huir pero el dragon te alcanza");
            Console.WriteLine("Final 10: El dragon te captura");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Opcion invalida Por favor elige 1 o 2");
        }
    }

    static void Capitulo3C()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("                     Capitulo 3C: El Acuerdo              ");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.ResetColor();

        Console.WriteLine("El dragon acepta tu oferta valiosa y libera a la princesa");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("          /\\_/\\  ");
        Console.WriteLine("         ( o.o ) ");
        Console.WriteLine("          > ^ <  ");
        Console.WriteLine("         /\\   /\\ ");
        Console.WriteLine("        /  \\ /  \\");
        Console.ResetColor();

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Que decides hacer");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("1. Regresas a casa con la princesa (Final 7: Ambos regresan sanos y salvos)");
        Console.WriteLine("2. Decides quedarte con el dragon para negociar mas acuerdos (Final 8: El dragon traiciona y te captura)");
        Console.WriteLine();

        Console.Write("Elige una opcion (1 o 2): ");
        string eleccion = Console.ReadLine();

        if (eleccion == "1")
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Regresas a casa con la princesa");
            Console.WriteLine("Final 7: Ambos regresan sanos y salvos");
            Console.ResetColor();
        }
        else if (eleccion == "2")
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Decides quedarte con el dragon");
            Console.WriteLine("Final 8: El dragon traiciona y te captura");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Opcion invalida Por favor elige 1 o 2");
        }
    }

    static void Capitulo3D()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("                     Capitulo 3D: El Ataque Sorpresa       ");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.ResetColor();

        Console.WriteLine("El dragon esta furioso por tu ataque y lucha contigo");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("              /\\_/\\   ");
        Console.WriteLine("             ( o.o )  ");
        Console.WriteLine("              > ^ <   ");
        Console.WriteLine("             /   \\   ");
        Console.WriteLine("            /_____/   ");
        Console.ResetColor();

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Que decides hacer");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("1. Te enfrentas al dragon en una batalla epica (Final 9: Sobrevives con la princesa)");
        Console.WriteLine("2. Intentas huir pero el dragon te alcanza (Final 10: El dragon te captura)");
        Console.WriteLine();

        Console.Write("Elige una opcion (1 o 2): ");
        string eleccion = Console.ReadLine();

        if (eleccion == "1")
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Te enfrentas al dragon en una batalla epica");
            Console.WriteLine("Final 9: Sobrevives con la princesa");
            Console.ResetColor();
        }
        else if (eleccion == "2")
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Intentas huir pero el dragon te alcanza");
            Console.WriteLine("Final 10: El dragon te captura");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Opcion invalida Por favor elige 1 o 2");
        }
    }
}
