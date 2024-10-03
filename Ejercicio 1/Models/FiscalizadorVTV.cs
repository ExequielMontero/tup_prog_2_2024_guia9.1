using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class FiscalizadorVTV
    {
        public List<VTV> vTVs = new List<VTV>();
        public int Cantidad { get; private set; }
        public VTV this[int idx]
        {
            get { return vTVs[idx]; }
        }

        public VTV AgregarVTV(string patente, Propietario propietario)
        {
            VTV actual = new VTV(propietario, patente);
            vTVs.Add(actual);
            return actual;
        }

        public VTV VerVTVPorPatente(string patente)
        {
            vTVs.Sort();
            int idx = vTVs.BinarySearch(new VTV(patente));
            VTV actual = vTVs[idx];
            if(idx<=0)
            {
                return actual;
            }
            return null;
        }

    }
}
