using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia9._1.Models
{
    internal abstract class Evaluacion
    {
        public string Nombre { get; protected set; }
        public string Descripcion { get; protected set; }
        public Evaluacion(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
        abstract public TipoAprobacion Evaluar();
        public override string ToString()
        {
            string nombre = Nombre.Length > 20 ? Nombre.Substring(0, 17) + "..." : Nombre.PadRight(20, '_');
            string descripcion = Descripcion.Length > 20 ? Descripcion.Substring(0, 17) + "..." : Descripcion.PadRight(20, '_');
            return $"{nombre} - {descripcion} - {Evaluar()}";
        }
    }
}
