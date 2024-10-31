using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia9._1.Models
{
    internal class VTV : IComparable
    {
        public Propietario Propietario { get; private set; }
        List<Evaluacion> evaluaciones = new List<Evaluacion>();
        public string Patente { get; private set; }
        public DateTime Fecha { get; private set; }
        public DateTime FechaVencimiento { get; private set; }
        public int CantidadEvaluaciones
        {
            get
            {
                return evaluaciones.Count;
            }
        }
        public Evaluacion this[int idx]
        {
            get
            {
                if (idx >= 0 && idx <= CantidadEvaluaciones)
                {
                    return evaluaciones[idx];
                }
                else
                {
                    return null;
                }
            }
        }
        public TipoAprobacion Aprobacion
        {
            get
            {
                bool parcial = false;
                bool noaprobado = false;
                for (int i = 0; i < CantidadEvaluaciones; i++)
                {
                    if (evaluaciones[i].Evaluar() == TipoAprobacion.NoAprobado)
                    {
                        noaprobado = true;
                    }
                    else if (evaluaciones[i].Evaluar() == TipoAprobacion.Parcial)
                    {
                        parcial = true;
                    }
                }
                if (noaprobado)
                {
                    return TipoAprobacion.NoAprobado;
                }
                else if (parcial)
                {
                    FechaVencimiento = Fecha.AddDays(20);
                    return TipoAprobacion.Parcial;
                }
                else
                {
                    FechaVencimiento = Fecha.AddYears(1);
                    return TipoAprobacion.Aprobado;
                }
            }

        }
        public VTV(string patente, Propietario propietario, DateTime fecha)
        {
            if (Regex.Match(patente, @"^[a-zA-z]{2}\d{3}[a-zA-z]{2}$||^[a-zA-z]{3}\d{3}$").Success == false)
            {
                throw new Ipatente();
            }
            Patente = patente;
            Propietario = propietario;
            Fecha = fecha;
            evaluaciones.Add(new EvaluacionParametrica("Prueba de frenos delanteros", "Porcentaje de diferencia de freando entre ejes", 0, 30, "Porcentaje", 30));
            evaluaciones.Add(new EvaluacionParametrica("Prueba de frenos traseros", "Porcentaje de diferencia de freando entre ejes", 0, 30, "Porcentaje", 30));
            evaluaciones.Add(new EvaluacionParametrica("Alineación", "Convergencia en grados", 0, 0.5, "Grado", 30));
            evaluaciones.Add(new EvaluacionParametrica("Luces de corto alcance", "Intensidad lumínica", 10000, 15000, "Candela", 30));
            evaluaciones.Add(new EvaluacionParametrica("Luces de largo alcance", "Intensidad lumínica", 30000, 40000, "Candela", 30));
            evaluaciones.Add(new EvaluacionSimple("Bocina", "Funcionamiento correcto"));

        }
        public string[] EmitirComprobante()
        {
            int j = 0;
            string[] r = new string[CantidadEvaluaciones + 2];

            r[j++] = ToString();

            for (int i = 0; i < CantidadEvaluaciones; i++)
            {
                r[j++] = evaluaciones[i].ToString();
            }

            string fechaVencimiento = FechaVencimiento > DateTime.MinValue ? $"- Vencimiento:{FechaVencimiento:dd/MM/yyyy}" : "";
            r[j++] = $"Resultado:{Aprobacion} {fechaVencimiento}";
            return r;
        }
        public override string ToString()
        {

            TipoAprobacion estado = Aprobacion;
            if (estado == TipoAprobacion.NoAprobado)
                return $"{Patente,8} | {estado,15} | {Propietario.Dni,10} | Fecha:{Fecha:dd/MM/yyyy} ";
            else
                return $"{Patente,8} | {estado,15} | {Propietario.Dni,10} | Fecha:{Fecha:dd/MM/yyyy} | Fecha Ven:{FechaVencimiento:dd/MM/yyyy}";
        }
        public int CompareTo(object obj)
        {
            if (obj is Propietario && obj != null)
            {
                return Propietario.Dni.CompareTo(((Propietario)obj).Dni);
            }
            return 0;
        }
    }
}

