using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia9._1.Models
{
    internal class FiscalizadorVtv
    {
        List<VTV> vtvs = new List<VTV>();

        public int CantidadVTVs
        {
            get
            {
                return vtvs.Count;
            }
        }

        public VTV AgregarVTV(string patente, Propietario propietario, DateTime fecha)
        {
            VTV nuevo = new VTV(patente, propietario, fecha);
            vtvs.Add(nuevo);
            return nuevo;
        }

        public VTV this[int idx]
        {
            get
            {
                if (idx >= 0 && idx < CantidadVTVs)
                    return vtvs[idx];
                return null;
            }
        }

        public List<VTV> VerVTVPorPatente(string patente)
        {
            List<VTV> vtvsPorPantente = new List<VTV>();
            foreach (VTV vtv in vtvs)
            {
                if (vtv.Patente == patente)
                    vtvsPorPantente.Add(vtv);
            }
            OrdenarVTVsPorDNIPropietario();
            return vtvsPorPantente;
        }

        public void OrdenarVTVsPorDNIPropietario()
        {
            vtvs.Sort();
        }
    }
}
