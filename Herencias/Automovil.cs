﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencias
{
    public class Automovil : I_Vehiculos
    {
        public string? Marca { get; set; }
        public string? Tipo { get; set; }
        public string? Modelo { get; set; }
        public string? Carrocería { get; set; }
    }
}