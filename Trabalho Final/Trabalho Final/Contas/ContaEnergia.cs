﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final.Contas
{
    class ContaEnergia : Conta
    {
        public ContaEnergia() {
            setTipo("energia"); 
        }
        public  string CalculaValor()
        {
            throw new NotImplementedException();
        }
    }
}
