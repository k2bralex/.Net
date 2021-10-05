using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public class Food : Consumer
    {
        private string _article;

        public string Article { get; set; }
        public Food(double price, string manufacturer, string article) : base(price, manufacturer)
        {
            _article = Article;
        }

        public override string ToString()
        {
            return $"{base.ToString()} \t {Article}";
        }
    }
}