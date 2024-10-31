using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia9._1.Models
{
    internal class Idni:ApplicationException
    {
        public Idni() : base("Dni debe ser inferior a 1000000")
        {
        }
        public Idni(string message) : base(message)
        {
        }

        public Idni(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
