﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string NumeroDocumento { get; set; }
        public string NombreCompleto { get; set; }

        public string Provincia { get; set; }

    }
}
