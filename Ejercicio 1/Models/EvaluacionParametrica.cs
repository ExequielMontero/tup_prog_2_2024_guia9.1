using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class EvaluacionParametrica:Evaluacion
    {
        public string Patente { get; private set; }
        public double ValorMaximo { get; private set; }
        public string Unidad { get; private set; }
        public double ValorMinimo { get; private set; }

        public double ValorTolerado {  get; private set; }
        public double ValorMedido;

        public EvaluacionParametrica(string patente, double valorMaximo, string unidad, double valorMinimo, double valorTolerado, string nombre, string descripcion):base (nombre, descripcion)
        {
            Patente = patente;
            ValorMaximo = valorMaximo;
            Unidad = unidad;
            ValorMinimo = valorMinimo;
            ValorTolerado = valorTolerado;
        }

        public override TipoAprobacion Evaluar()
        {
            double porcentaje = ValorMinimo * 0.7;
            if (ValorMedido < porcentaje)
            {
                return TipoAprobacion.NoAprobado;
            }
            else if(ValorMedido == ValorMinimo)
            {
                return TipoAprobacion.Parcial;
            }
            return TipoAprobacion.Aprobado;      
        }

        //public override string ToString()
        //{
        //    return $"Patente: {Patente}, Valor Medido: {ValorMedido}";
        //}

    }
}
