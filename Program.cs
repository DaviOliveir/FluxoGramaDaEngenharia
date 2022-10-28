
Console.WriteLine("   Fluxograma Da Engenharia    \n");

Console.Write("O objeto esta se movendo S/N?");

bool EstaSeMovendo = Console.ReadLine()!.Trim().Substring(0,1).ToUpper() == "S";

Console.Write("deveria?");

bool Deveria = Console.ReadLine()!.Trim().Substring(0,1).ToUpper() == "S";

string Mensagem;

if (!EstaSeMovendo)
{

    if (!Deveria)

    {
        Mensagem = "ótimo!";

    }

    else

    {

        Mensagem = "Use WD-40.";

    }

}

else

{
      if (Deveria)

     {

        Mensagem = "Ótimo!";

    }   

    else

     {

        Mensagem = "Use Silver Tape.";

     }

}

Console.WriteLine();

Console.WriteLine(Mensagem);
