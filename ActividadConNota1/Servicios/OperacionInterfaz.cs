﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadConNota1.Servicios
{
    internal interface OperacionInterfaz
    {
        public bool bisiesto(int any);


        public int dias(bool bisiesto);
    }
}
