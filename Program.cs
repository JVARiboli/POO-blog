using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace Blog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Blog blog = new Blog();
            bool terminate = true;
            do
            {
                Console.Clear();
                Menu();
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        blog.ReadData(new News());
                        Console.ReadKey();
                        break;
                    case 2:
                        blog.ReadData(new ProductReview());
                        Console.ReadKey();  
                        break;
                    case 3:
                        blog.ReadData(new Post());
                        Console.ReadKey();
                        break;
                    case 4:
                        blog.ShowAll();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Write("Digite o código do post: ");
                        int codigoDoPost = int.Parse(Console.ReadLine()) - 1;
                        if (codigoDoPost >= 0 && codigoDoPost < blog.Posts.Count)
                        {
                           blog.Posts[codigoDoPost].Like();
                        }
                        else
                        {
                            Console.WriteLine("--Post inválido!--");
                        }
                        break;  
                    case 6:
                        Console.Write("Digite o código do post: ");
                        int codigoPost = int.Parse(Console.ReadLine()) - 1;
                        if (codigoPost >= 0 && codigoPost < blog.Posts.Count)
                        {
                            blog.Posts[codigoPost].Dislike();
                        }
                        else
                        {
                            Console.WriteLine("--Post inválido!--");
                        }
                        break;
                    case 0:
                        terminate = false;
                        break;
                    default:
                        Console.WriteLine("--Opção inválida!--");
                        break;
                }
            } while (terminate);
        }
        static void Menu()
        {
            Console.WriteLine("BLOG: O que você quer fazer ?\n"+
                              "1.Novo post de notícia\n" +
                              "2.Nova resenha de produto\n" +
                              "3.Novo post de outros assuntos\n" +
                              "4.Listar todas as postagens\n" +
                              "5.Curtir uma postagem\n" +
                              "6.Nao curtir uma postagem\n" +
                              "0.Sair\n" +
                              "Escolha a uma opção:");
        }
    }
}
