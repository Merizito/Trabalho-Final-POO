using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final.Contas
{
    class ContaAgua : Conta
    {
        string usuario;
        private double tarifaEsgoto, tarifaAgua, Total, consumo_real, consumo_contador;
        public ContaAgua() {
            setTipo("agua"); 
        }
        public override string CalcularValor(string _usuario)
        {
            this.usuario = _usuario;
            string VALOR = CalculaAgua();
            return VALOR;
        }


        public  string CalculaAgua()
        {
            
            if (usuario.ToUpper() == "RESIDENCIAL")
            {
                tarifaAgua = TarifaEsgotoResidencial() + TarifaAguaResidencial();
                tarifaAgua *= 1.03;
                setValor(tarifaAgua);
                return tarifaAgua.ToString();

            }
            else if (usuario.ToUpper() == "COMERCIAL")
            {
                tarifaAgua = TarifaEsgotoComercial() + TarifaAguaComercial();
                tarifaAgua *= 1.03;
                return tarifaAgua.ToString();

            }
            return "";
        }

        public double TarifaAguaComercial()
        {
            consumo_real = Convert.ToDouble(getConsumo());
            consumo_contador = Convert.ToDouble(getConsumo());

            tarifaAgua += 25.79;
            if (consumo_real > 6)
            {
                if (consumo_real < 10)
                {
                    tarifaAgua += consumo_contador * 4.299;
                    return tarifaAgua;
                }
                else
                {
                    tarifaAgua += 4 * 4.299;
                    consumo_contador -= 4;
                }
            }

            if (consumo_real > 10)
            {
                if (consumo_real < 40)
                {
                    tarifaAgua += consumo_contador * 8.221;
                    return tarifaAgua;
                }
                else
                {
                    tarifaAgua += 30 * 8.221;
                    consumo_contador -= 30;
                }
            }
            if (consumo_real > 40)
            {
                if (consumo_real < 100)
                {
                    tarifaAgua += consumo_contador * 8.288;
                    return tarifaAgua;
                }
                else
                {
                    tarifaAgua += 60* 8.288;
                    consumo_contador -= 60;
                }
            }
            if (consumo_real >= 100)
            {

                do
                {
                    if (consumo_contador > 100)
                    {
                        tarifaAgua += 100 * 8.329;

                    }
                    else
                    {
                        tarifaAgua += consumo_contador * 8.329;
                        return tarifaAgua;
                    }
                    consumo_contador -= 100;

                } while (0==0);
            }

            return tarifaAgua;
        }

        public double TarifaEsgotoComercial()
        {
            consumo_real = Convert.ToDouble(getConsumo());
            consumo_contador = Convert.ToDouble(getConsumo());

            tarifaEsgoto += 12.90;
            if (consumo_real > 6)
            {
                if (consumo_real < 10)
                {
                    tarifaEsgoto += consumo_contador * 2.149;
                    return tarifaEsgoto;
                }
                else
                {
                    tarifaEsgoto += 4 * 2.149;
                    consumo_contador -= 4;
                }
            }

            if (consumo_real > 10)
            {
                if (consumo_real < 40)
                {
                    tarifaEsgoto += consumo_contador * 4.111;
                    return tarifaEsgoto;
                }
                else
                {
                    tarifaEsgoto += 30 * 4.111;
                    consumo_contador -= 30;
                }
            }
            if (consumo_real > 40)
            {
                if (consumo_real < 100)
                {
                    tarifaEsgoto += consumo_contador * 4.144;
                    return tarifaEsgoto;
                }
                else
                {
                    tarifaAgua += 60 * 4.144;
                    consumo_contador -= 60;
                }
            }
            if (consumo_real >= 100)
            {

                do
                {
                    if (consumo_contador > 100)
                    {
                        tarifaAgua += 100 * 4.165;

                    }
                    else
                    {
                        tarifaEsgoto += consumo_contador * 4.165;
                        return tarifaEsgoto;
                    }
                    consumo_contador -= 100;

                } while (0 == 0);
            }

            return tarifaEsgoto;
        }

        public double TarifaAguaResidencial()
        {
            consumo_real = Convert.ToDouble(getConsumo());
            consumo_contador = Convert.ToDouble(getConsumo());

            tarifaAgua += 10.08;
            if (consumo_real > 6)
            {
                if (consumo_real < 10)
                {
                    tarifaAgua += consumo_contador * 2.241;
                    return tarifaAgua;
                }
                else
                {
                    tarifaAgua += 4 * 2.241;
                    consumo_contador -= 4;
                }
            }

            if (consumo_real > 10)
            {
                if (consumo_real < 15)
                {
                    tarifaAgua += consumo_contador * 5.447;
                    return tarifaAgua;
                }
                else
                {
                    tarifaAgua += 5 * 5.447;
                    consumo_contador -= 5;
                }
            }
            if (consumo_real > 15)
            {
                if (consumo_real < 20)
                {
                    tarifaAgua += consumo_contador * 5.461;
                    return tarifaAgua;
                }
                else
                {
                    tarifaAgua += 5 * 5.461;
                    consumo_contador -= 5;
                }
            }
            if (consumo_real > 20)
            {
                if (consumo_real < 40)
                {
                    tarifaAgua += consumo_contador * 5.487;
                    return tarifaAgua;
                }
                else
                {
                    tarifaAgua += 20 * 5.487;
                    consumo_contador -= 20;
                }
            }
            if (consumo_real >= 40)
            {

                do
                {
                    if (consumo_contador > 40)
                    {
                        tarifaAgua += 40 * 10.066;

                    }
                    else
                    {
                        tarifaAgua += consumo_contador * 10.066;
                        return tarifaAgua;
                    }
                    consumo_contador -= 40;

                } while (0 == 0);
            }

            return tarifaAgua;
        }
        public double TarifaEsgotoResidencial()
        {
            consumo_real = Convert.ToDouble(getConsumo());
            consumo_contador = Convert.ToDouble(getConsumo());

            tarifaEsgoto += 5.05;
            if (consumo_real > 6)
            {
                if (consumo_real < 10)
                {
                    tarifaEsgoto += consumo_contador * 1.122;
                    return tarifaEsgoto;
                }
                else
                {
                    tarifaEsgoto += 4 * 1.122;
                    consumo_contador -= 4;
                }
            }

            if (consumo_real > 10)
            {
                if (consumo_real < 15)
                {
                    tarifaEsgoto += consumo_contador * 2.724;
                    return tarifaEsgoto;
                }
                else
                {
                    tarifaEsgoto += 5 * 2.724;
                    consumo_contador -= 5;
                }
            }
            if (consumo_real > 15)
            {
                if (consumo_real < 20)
                {
                    tarifaAgua += consumo_contador * 2.731;
                    return tarifaEsgoto;
                }
                else
                {
                    tarifaEsgoto += 5 * 2.731;
                    consumo_contador -= 5;
                }
            }
            if (consumo_real > 20)
            {
                if (consumo_real < 40)
                {
                    tarifaEsgoto += consumo_contador * 2.744;
                    return tarifaEsgoto;
                }
                else
                {
                    tarifaEsgoto += 20 * 2.744;
                    consumo_contador -= 20;
                }
            }
            if (consumo_real >= 40)
            {

                do
                {
                    if (consumo_contador > 40)
                    {
                        tarifaEsgoto += 40 * 5.035;

                    }
                    else
                    {
                        tarifaEsgoto += consumo_contador * 5.035;
                        return tarifaEsgoto;
                    }
                    consumo_contador -= 40;

                } while (0 == 0);
            }

            return tarifaEsgoto;
        }
    }
}