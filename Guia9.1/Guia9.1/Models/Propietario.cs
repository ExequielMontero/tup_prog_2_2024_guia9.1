using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia9._1.Models
{
    internal class Propietario
    {
        public Propietario(int dni, string nombre, string correo)
        {
            if (Dni < 1000000)
            {
                Dni = dni;
            }
            else
            {
                throw new Idni();
            }

            if (Regex.Match(correo, @"^[a-zA-Z0-9]+@{1}[a-zA-Z0-9]+\.com$").Success == false)
            {
                throw new Iemail();
            }
            else
            {
                Email = correo;
            }

            ApellidosNombres = nombre;
        }

        public string ApellidosNombres { get; set; }
        public int Dni { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Dni: {Dni} \r\nNombre completo: {ApellidosNombres} \r\nEmail: {Email}";
        }
    }
}
