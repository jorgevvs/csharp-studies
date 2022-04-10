﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities
{
    public class ISS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}