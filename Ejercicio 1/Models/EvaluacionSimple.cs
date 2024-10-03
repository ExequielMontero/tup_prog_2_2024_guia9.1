using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class EvaluacionSimple:Evaluacion
    {
        public EvaluacionSimple(string nombre, string descripcion) : base(nombre, descripcion)
        {
        }

        public bool Haverificado { get; private set; }
        public override TipoAprobacion Evaluar()
        {
            if (Haverificado)
            {
                return TipoAprobacion.Aprobado;
            }

            return TipoAprobacion.NoAprobado;
        }

        public override string ToString()
        {
            return $"Evaluacion: {Evaluar().ToString()}";
        }
    }
}
