using iTones3.Modelos;

namespace iTones3.Menus;

internal class MenuSair:Menus
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("Até a próxima! :)");
    }
}
