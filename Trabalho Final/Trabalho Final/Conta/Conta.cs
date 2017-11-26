using System;
using System.Collections.Generic;
using Trabalho_Final.Usuarios;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final.Conta
{
   abstract class Conta
    {
        Usuario usuario;
        private string tipo;
        private string relatorio;
        public string getTipo() {
            return this.tipo;
        }
        public void setTipo(string tipo) {
            this.tipo = tipo;
        }
        public string getRelatorio()
        {
            return this.relatorio;
        }
        public void setRelatorio(string relatorio)
        {
            this.relatorio = relatorio;
        }
    }
}
