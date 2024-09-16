using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class Blog
    {
        public List<Post> Posts = new List<Post>();
        public void ShowAll() 
        {
            foreach (var post in Posts)
                post.Show();
        }
        public void ReadData(Post post) 
        {
            Console.Write("Título: ");
            post.Title = Console.ReadLine();
            post.Date = DateTime.Now;
            Console.Write("Conteúdo: ");
            post.Content = Console.ReadLine();
            if (post is News news)
            {
                Console.Write("Fonte: ");
                news.Source = Console.ReadLine();
            }
            if (post is ProductReview productReview)
            {
                Console.WriteLine($"Marca:");
                productReview.Brand = Console.ReadLine();
                Console.WriteLine($"Estrelas:");
                productReview.Stars = Convert.ToInt32(Console.ReadLine());
            }
            Posts.Add(post);
        }
    }
}
