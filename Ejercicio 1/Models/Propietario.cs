using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.Models
{
    internal class Propietario
    {
        public int Dni;
        public string ApellidosNombres;
        public string Email;

        public Propietario(int dni, string apellidosNombres, string email)
        {
            Dni = dni;
            ApellidosNombres = apellidosNombres;
            Email = email;
        }

        public override string ToString()
        {
            return $"Nombre: {ApellidosNombres}, Dni:{Dni}, Email: {Email}";
        }
    }
}
