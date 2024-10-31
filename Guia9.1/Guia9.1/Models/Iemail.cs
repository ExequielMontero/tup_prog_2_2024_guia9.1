using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia9._1.Models
{
    internal class Iemail:ApplicationException
    {
        public Iemail() : base("Email no valido")
        {
        }
        public Iemail(string message) : base(message)
        {
        }

        public Iemail(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
