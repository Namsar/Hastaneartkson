using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HastaneYönetimSistemi
{
    public class Context
    {
        public List<Doktor> Doktorlar { get; set; } = new List<Doktor>();
        public List<Hemsire> Hemsireler { get; set; } = new List<Hemsire>();
        public List<HastaneRandevu> Randevular { get; set; } = new List<HastaneRandevu>();
    }
}
