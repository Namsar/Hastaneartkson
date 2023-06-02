using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYönetimSistemi
{
    public class DoktorSınıfı
    {
        public List<Hemsire> DoktorunHemsiresi { get; set; } = new List<Hemsire>();
        private Branslar _brans;
        private decimal _maas;
        public Branslar Brans
        {
            get
            {
                return _brans;
            }

            set
            {
                _brans = value;
            }
        }

        public decimal Maas
        {
            get
            {
                return _maas;
            }

            set
            {
                _maas = value;
            }
        }
        public enum Branslar
        {

            Dahiliye,
            Nöroloji,
            Kardiyoloji,
            Gastroloji,
            Ortopedi,
            KBB,

        }
      
    }
}
