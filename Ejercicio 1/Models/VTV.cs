using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class VTV:IComparable
    {
        List<Evaluacion> evaluaciones = new List<Evaluacion>();

        public VTV(Propietario propietario, string patente)
        {
            this.propietario = propietario;
            Patente = patente;
        }

        public VTV(string patente)
        {
            Patente = patente;
        }

        public Propietario propietario { get; private set; }
        public string Patente { get; private set; }
        public DateTime Fecha { get; private set; }
        public int CantidadVerificaciones { get; private set; }
        public Evaluacion this[int idx]
        {
            get { return evaluaciones[idx]; }
        }
        public TipoAprobacion Aprobacion { get; private set; }
        
        public string[] EmitirComprobante()
        {
            int n = 0;
            string[] resumen = new string[evaluaciones.Count + 1];
            resumen[n++] += $"propietario.ToString()\r\n";
            foreach(Evaluacion j in evaluaciones)
            {
                resumen[n++] += $"j.ToString()\r\n";
            }
            return resumen;
        }

        public override string ToString()
        {
            return $"Nombre: {propietario.ApellidosNombres}, Patente: {Patente}, Fecha: {Fecha}, Cantidad de Verificaciones: {CantidadVerificaciones}";
        }

        public int CompareTo(object obj)
        {
            VTV actual = obj as VTV;
            if(actual != null)
            {
                return this.Patente.CompareTo(actual.Patente);
            }
            return 1;
        }

    }
}
