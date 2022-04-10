using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Entities
{
    public interface Imposto
    { 
        double Calcula(Orcamento orcamento);
    }
}
