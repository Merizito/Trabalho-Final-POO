﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final.Conta
{
    class ContaEnergia : Conta, IConta
    {
        public ContaEnergia() {
            setTipo("energia");
        }

    }
}
