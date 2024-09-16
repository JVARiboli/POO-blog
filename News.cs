using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class News : Post
    {
        public string Source { get; set; }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Fonte: {Source}");
        }
    }
}
