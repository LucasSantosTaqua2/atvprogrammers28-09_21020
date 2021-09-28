using System;

namespace ATV2809
{
    class Program
    {
        static void Main(string[] args)
        {
            string res = string.Empty;
            string jogos = string.Empty;

            string[] livros = new string[5];
            livros[0] = "A culpa é das estrelas";
            livros[1] = "Uma breve história do tempo";
            livros[2] = "Percy jackson";
            livros[3] = "Pequeno Principe";
            livros[4] = "Harry Potter";

            string[] listajogos = new string[5];
            listajogos[0] = "CS:GO";
            listajogos[1] = "Valorant";
            listajogos[2] = "Minecraft";
            listajogos[3] = "Dota 2";
            listajogos[4] = "The Witcher 3";


            Console.WriteLine("Por favor digite uma lista que você queira exibir (livro para exibir uma lista com 5 livros ou jogos para exibir uma lista com 5 jogos");
            res = Console.ReadLine();


            if (res == "livro")
            {
                Console.WriteLine("A lista de livros é:");
                for (int i = 0; i < res.Length; i++)
                {
                    Console.WriteLine($"Livro: {livros[i]}");

                }
            }
    

    
            if (res == "jogos"){

                Console.WriteLine("A lista de jogos é:");
                foreach (string games in listajogos)
                {
                    Console.WriteLine(games);
                }


            }

            else {
                Console.WriteLine("Por favor reinicie e digite uma das opções citadas");
            }
        }
    }
}
