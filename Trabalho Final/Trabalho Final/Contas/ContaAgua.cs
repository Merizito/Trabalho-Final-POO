using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final.Contas
{
    class ContaAgua : Conta
    {
        private double tarifaEsgoto, tarifaAgua, Total, consumo_real, consumo_contador;
        public ContaAgua() {
            setTipo("agua"); 
        }
        public  string CalculaAgua()
        {
            if (getConsumidor().ToUpper() == "RESIDENCIAL")
            {
                tarifaAgua = TarifaEsgotoResidencial() + TarifaAguaResidencial();
                return tarifaAgua.ToString();
            }
            else if (getConsumidor().ToUpper() == "COMERCIAL")
            {
                tarifaAgua = TarifaEsgotoComercial() + TarifaAguaComercial();
                return tarifaAgua.ToString();

            }
            return "";
        }

        public  string CalculaEsgoto()
        {
            throw new NotImplementedException();
        }

        public double TarifaAguaComercial()
        {
            consumo_real = Convert.ToDouble(getConsumo());
            consumo_contador = Convert.ToDouble(getConsumo());

            if (consumo_real > 10 && consumo_contador > 10)
            {
                consumo_contador = consumo_contador - 10;
                tarifaAgua += 10 * 4.299;
            }
            else
            {
                
            }
            if (consumo_real > 40)
            {
                tarifaAgua += 5 * 4
            }
            if (consumo_real > 100)
            {

            }
            if (consumo_real >= 101)
            {

            }
        }

        public double TarifaEsgotoComercial()
        {
            return 0;
        }

        public double TarifaAguaResidencial()
        {
            consumo_real = Convert.ToDouble(getConsumo());
            consumo_contador = Convert.ToDouble(getConsumo());

            if (consumo_real > 10)
            {

            }
            if (consumo_real > 15)
            {

            }
            if (consumo_real > 20)
            {

            }
            if (consumo_real >= 40)
            {

            }
        }
        public double TarifaEsgotoResidencial() {
            double valor=0;

            do
            {
                if (Convert.ToInt32(getConsumo()) >= 40)
                {
                    valor += Convert.ToDouble(getConsumo())+(5.035);
                    tarifaEsgoto = valor;
                    setConsumo(Convert.ToDouble(getConsumo()) - 40);
                }
                
            } while (Convert.ToDouble(getConsumo()) <= 0);
            
            

            return this.tarifaEsgoto;
        }
    }
}
