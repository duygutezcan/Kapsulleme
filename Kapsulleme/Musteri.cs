using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    internal class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        
        public string _KartNo1 { get => KartNo; set => KartNo = 
                value.Substring(0, 2) + "*************" +  value.Substring
                (value.Length - 4); }
        private string KartNo;
    }
}
