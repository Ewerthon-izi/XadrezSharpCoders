using xadrezCsharp.partida;
using xadrezCsharp.tabuleiro;

static void Main(string[] args)
{
    try
    {
        PartidaXadrez partida = new PartidaXadrez();
        Console.WriteLine(partida.turno);
    }
    catch (TabuleiroException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        Console.ReadLine();
    }
}
