using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    abstract class  Evaluacion
    {
        public Evaluacion(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }

        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Descripcion: {Descripcion} - {Evaluar()}";
        }

        public abstract TipoAprobacion Evaluar();

    }
}
