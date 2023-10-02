class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => // é uma função lambda get
        $"A musica {Nome} pertence a banda {Artista} ";

    public void ExibirFichaTecnica() // metodo sem retorno > void, dentro de um método colocamos instruções
    {
        Console.WriteLine($"Nome da Música: {Nome}");
        Console.WriteLine($"Nome do artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel) 
        {
            Console.WriteLine("Disponível no plano");
        } else 
        {
            Console.WriteLine("Adquira o plano Plus+"); 
        }
    }

    //public void ExibirNomeeArtista()
    //{
    //    Console.WriteLine($"Nome do artista: {artista}");
    //    Console.WriteLine($"Nome da Música: {nome}");
    //}
}