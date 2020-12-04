using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobüsFirma
{
    public class Sefer
    {
        public int sefer_no;
        public string plaka;
        public DateTime seferTarih;
        List<Koltuk> Koltuklar = new List<Koltuk>();
    }
}
