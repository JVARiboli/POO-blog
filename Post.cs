using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class Post
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }

        public void Like() => Likes++;
        public void Dislike() => Dislikes++;

        public virtual void Show()
        {
            Console.WriteLine($"Título: {Title}\n"+
                              $"Data: {Date.ToShortDateString()}\n"+
                              $"Conteúdo: {Content} \n"+
                              $"Curtidas: {Likes}, Não Curtidas: {Dislikes}");
        }
    }
}
