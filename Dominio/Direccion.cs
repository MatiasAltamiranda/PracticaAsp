﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Direccion
    {
        public  string Nombre { get; set; }
        public int altura { get; set; }

        public override string ToString()
        {
            return Nombre+ " " + altura;
        }
    }
}