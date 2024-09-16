using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class ProductReview : Post
    {
        public string Brand {  get; set; }
        public int Stars { get; set; }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Marca: {Brand}");
            Console.WriteLine($"Estrelas: {Stars}");
        }
    }
}
