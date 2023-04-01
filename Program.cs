void Shin (int fun)
{
     if (fun == 00)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
    }
    else if (fun == 01)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
        else if (fun == 02)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
    }
}
Console.Clear();

void barra()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("<=============================>");
}

void informacao()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("_________________________");
}

Shin(02);
Console.WriteLine("{-x- Formulário -x-}");
informacao();

Shin(01);
Console.WriteLine("Qual é a espécie?");
string especie = Console.ReadLine()!;
informacao();


Shin(01);
Console.WriteLine("Qual é a raça?");
string raca = Console.ReadLine()!;
informacao();

Shin(01);
Console.WriteLine("Qual é a apelido?");
string apelido = Console.ReadLine()!;
informacao();

Shin(01);
Console.WriteLine("Qual é a idade?");
string idade = Console.ReadLine()!;
informacao();

Shin(01);
Console.WriteLine("Qual é a Pelagem/Cor?");
string color = Console.ReadLine()!;
informacao();

Console.Clear();
barra();
Shin(0);
Console.WriteLine("|======    Pet Hotel!   ======|");
barra();
Shin(0);
Console.WriteLine($"| Espécie: {especie.PadRight(18,'.').Substring(0,18)} |"); // 18 pontos.
barra();
Shin(0);
Console.WriteLine($"| Raça:    {raca.PadRight(18,'.').Substring(0,18)} |"); // 18 pontos.
barra();
Shin(0);
Console.WriteLine($"| Apelido: {apelido.PadRight(18,'.').Substring(0,18)} |"); // 18 pontos.
barra();
Shin(0);
Console.WriteLine($"| Idade:   {idade.PadRight(18,'.').Substring(0,18)} |"); // 18 pontos.
barra();
Shin(0);
Console.WriteLine($"| Cor:     {color.PadRight(18,'.').Substring(0,18)} |"); // 18 pontos.
barra();
Console.ResetColor();
