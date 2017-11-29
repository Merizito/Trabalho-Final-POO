using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final.Contas
{
    class ContaEnergia : Conta
    {
        string usuario;
        private double tarifaEnergia, Total;

        public ContaEnergia() {
            setTipo("energia"); 
        }
        public override string CalcularValor(string _usuario)
        {
            this.usuario = _usuario;
            string valor = CalculaEnergia();
            return valor;
        }

        public string CalculaEnergia()
        {
            if (usuario.ToUpper() == "RESIDENCIAL")
            {
                tarifaEnergia = TarifaEnergiaResidencial()+13.25;
                if (Convert.ToDouble(getConsumo()) > 90)
                    tarifaEnergia *= 1.4285;
                setValor(tarifaEnergia);
                return tarifaEnergia.ToString();

            }
            else if (usuario.ToUpper() == "COMERCIAL")
            {
                tarifaEnergia = TarifaEnergiaComercial()+13.25;
                tarifaEnergia *= 1.2195;
                return tarifaEnergia.ToString();

            }
            return "";
        }

        public double TarifaEnergiaComercial()
        {
            tarifaEnergia = 0.41;
            Total = Convert.ToDouble(getConsumo()) * tarifaEnergia;
            return Total;
        }

        public double TarifaEnergiaResidencial()
        {
            tarifaEnergia = 0.46;
            Total = Convert.ToDouble(getConsumo()) * tarifaEnergia;
            return Total;
        }

    }
}
