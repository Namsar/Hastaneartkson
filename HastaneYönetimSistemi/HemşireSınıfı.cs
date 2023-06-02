using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYönetimSistemi
{
    public class HemşireSınıfı
    {
        private HBranslar _brans;
        public bool bosMu { get; set; }
        public HBranslar Brans
        {
            get { return _brans; }
            set { _brans = value; }
        }

     
    }
    public enum HBranslar
    {
        Ortopedi,
        Dahiliye,
        KBB,
        Nöroloji,
        Kardiyoloji,
        Cildiye,
        Gastroloji
    }
    public enum Cinsiyet
    {
        Erkek,
        Kadın,
        Belirtmek_istemiyorum
    }

}

