﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioMembrosEstaticos
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double CalculoConverter(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            
            return total + total * Iof / 100.0;
        }

    }
}
