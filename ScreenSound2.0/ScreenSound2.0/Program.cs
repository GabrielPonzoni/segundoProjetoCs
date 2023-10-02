
Musica musica1 = new Musica();
musica1.Nome = "Roxane";
musica1.Artista = "The police";
musica1.Duracao = 273;
musica1.Disponivel = true;
musica1.ExibirFichaTecnica();
//musica1.ExibirNomeeArtista();

Musica musica2 = new Musica();
musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 367;
musica2.Disponivel = false;
musica2.ExibirFichaTecnica();
//musica2.ExibirNomeeArtista();

Console.WriteLine(musica1.DescricaoResumida);