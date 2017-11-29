using System;
using System.Collections.Generic;
using Trabalho_Final.Usuarios;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final.Contas
{
   
    public abstract class Conta
    {
        private string relatorio, tipo, consumo, valor, consumidor;
        public string getTipo() {
            return this.tipo;
        }
        public void setTipo(string _tipo) {
            this.tipo = _tipo;
        }
        public string getRelatorio()
        {
            return this.relatorio;
        }
        public void setRelatorio(string _relatorio)
        {
            this.relatorio = _relatorio;
        }
        public string getValor() {
            return this.valor;
            //calcular valor
        }
        public string getConsumidor() {
            return this.consumidor;
        }
        public void setValor(double _valor) {
            this.valor = Convert.ToString(_valor);
        }
        public virtual string CalcularValor(string usuario) { return usuario; }
        public void setConsumidor(string consumidor)
        {
            this.consumidor = consumidor;
        }
       
        public string getConsumo()
        {
            return this.consumo;
        }
        public void setConsumo(double valor)
        {
            consumo = Convert.ToString(valor);
        }
    }
}














