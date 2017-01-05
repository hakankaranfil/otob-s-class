using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeSiparişEkranı
{
    public class yemek : Masa
    {
        public string ad { get; set; }
        public int ucret { get; set; }
        public int yemekadeti { get; set; }
        public override string ToString()
        {
            return "yemek adı:"+ this.ad +" " +"adet:" +  this.yemekadeti;




        }

    }
}

