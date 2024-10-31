using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia9._1.Models
{
    internal class Ipatente : ApplicationException
    {
        public Ipatente() : base("Patente no valida")
        {
        }
        public Ipatente(string message) : base(message)
        {
        }

        public Ipatente(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
