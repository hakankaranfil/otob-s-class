using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeSiparişEkranı
{
    public class icecek : Masa
    {
        public string ad { get; set; }
        public int ucret { get; set; }
        public int iceekadeti { get; set; }

        public override string ToString()
        {
            return "içeçek adı:"+this.ad+" "+ "içeçekadeti="+this.iceekadeti;
        }
    }
}
