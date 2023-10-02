class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica() // metodo sem retorno > void, dentro de um método colocamos instruções
    {
        Console.WriteLine($"Nome da Música: {nome}");
        Console.WriteLine($"Nome do artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponivel) 
        {
            Console.WriteLine("Disponível no plano");
        } else 
        {
            Console.WriteLine("Adquira o plano Plus+"); 
        }
    }
}