using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Trabalho_Final.Usuarios;
using System.IO;
using System.Text;
using Trabalho_Final.Contas;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Final.Relatorios
{
    public partial class Exibir_Relatorio_Forms : Form
    {
        string tipo;
        public Exibir_Relatorio_Forms()
        {
            InitializeComponent();
        }

        private void Exibir_Relatorio_Forms_Load(object sender, EventArgs e)
        {
            
        }
       
        public Exibir_Relatorio_Forms(Conta conta, Usuario usuario) {

            InitializeComponent();

            if (conta.getTipo() == "agua")
                relatoriosAgua(conta, usuario);
            else if (conta.getTipo() == "energia")
                relatoriosEnergia(conta, usuario);
            else
                MessageBox.Show("TIPO ERRADO");

        }




        public void relatoriosAgua(Conta conta, Usuario usuario) {

            StreamReader informa = Program.abrirArquivo("USUARIOS");
            string x = conta.getRelatorio();
            if (conta.getRelatorio().Contains("1"))
            {
                int dia = 0;
                int ano = 0;
                int mes = 0;
                string linhas;
                do
                {
                    linhas = informa.ReadLine();
                    if(linhas !=null){
                        if (linhas.Contains(usuario.getCPF()))
                        {
                            string diretorio =Directory.GetCurrentDirectory();
                        
                            StreamReader ler = Program.abrirArquivo(diretorio + @"\" + usuario.getCPF() + @"\relatorio" + conta.getTipo());
                            string linha;
                            do
                            {
                                linha = ler.ReadLine();
                                if (linha != null) {
                                    string[] data = linha.Replace("Consumo: ", "").Replace("Valor:","").Replace("&","").Split('/','\t');

                                    if (Convert.ToInt32(data[2]) > ano||(Convert.ToInt32(data[2]) == ano&&Convert.ToInt32(data[1])>mes)||(Convert.ToInt32(data[2]) == ano&& Convert.ToInt32(data[1]) == mes&& Convert.ToInt32(data[0]) > dia))
                                    {
                                        dia = Convert.ToInt32(data[0]);
                                        mes = Convert.ToInt32(data[1]);
                                        ano = Convert.ToInt32(data[2]);
                                        conta.setConsumo(Convert.ToDouble(data[4]));
                                        conta.setValor(Convert.ToDouble(data[5]));
                                     
                                    }

                                    
                                }

                            } while (linha != null);
                        }
                    }
                } while (linhas != null);
                textBox_Data.Text = dia + "/" + mes + "/" + ano;
                textBox_CPF.Text = usuario.getCPF().ToString();
                textBox_Consumo.Text = conta.getConsumo().ToString();//droga
                textBox_Valor.Text = conta.getValor();
                textBox_NomeUsu.Text = usuario.getNome();
            }
            if (conta.getRelatorio().Contains("2")) {
                string linhas;
                double totalvalor = 0, totalconsumo=0;
                do
                {
                    linhas = informa.ReadLine();
                    if (linhas != null)
                    {
                        if (linhas.Contains(usuario.getCPF()))
                        {
                            string diretorio = Directory.GetCurrentDirectory();

                            StreamReader ler = Program.abrirArquivo(diretorio + @"\" + usuario.getCPF() + @"\relatorio" + conta.getTipo());
                            string linha;
                            do
                            {
                                linha = ler.ReadLine();
                                if (linha != null)
                                {
                                    string[] data = linha.Replace("Consumo: ", "").Replace("Valor:", "").Replace("&", "").Split('/', '\t');

                                   
                                       totalvalor+=Convert.ToDouble(data[5]);
                                    totalconsumo += Convert.ToDouble(data[4]);
                                   


                                }

                            } while (linha != null);
                        }
                    }
                } while (linhas != null);
                textBox_Data.Text = "00" + "/" + "00" + "/" + "00";
                textBox_CPF.Text = usuario.getCPF().ToString();
                textBox_Consumo.Text = totalconsumo.ToString();
                textBox_Valor.Text = totalvalor.ToString();
                textBox_NomeUsu.Text = usuario.getNome();
            }
            if (conta.getRelatorio().Contains("3")) {
                string linhas;
                double totalvalor = 0, totalconsumo = 0;
                do
                {
                    linhas = informa.ReadLine();
                    if (linhas != null)
                    {
                        if (linhas.Contains(usuario.getCPF()))
                        {
                            string diretorio = Directory.GetCurrentDirectory();

                            StreamReader ler = Program.abrirArquivo(diretorio + @"\" + usuario.getCPF() + @"\relatorio" + conta.getTipo());
                            string linha;
                            do
                            {
                                linha = ler.ReadLine();
                                if (linha != null)
                                {
                                    string[] data = linha.Replace("Consumo: ", "").Replace("Valor:", "").Replace("&", "").Split('/', '\t');


                                    totalvalor += Convert.ToDouble(data[5]);
                                    totalconsumo += Convert.ToDouble(data[4]);



                                }

                            } while (linha != null);
                        }
                    }
                } while (linhas != null);

                textBox_Data.Text = "00" + "/" + "00" + "/" + "00";
                textBox_CPF.Text = usuario.getCPF().ToString();
                textBox_Consumo.Text = totalconsumo.ToString();
                textBox_Valor.Text = (totalvalor / 1.03).ToString();
                textBox_NomeUsu.Text = usuario.getNome();

            }
            if (conta.getRelatorio().Contains("5"))
            {
                string linhas;
                int contador=0;
                double totalvalor = 0, totalconsumo = 0;
                do
                {
                    linhas = informa.ReadLine();
                    if (linhas != null)
                    {
                        if (linhas.Contains(usuario.getCPF()))
                        {
                            string diretorio = Directory.GetCurrentDirectory();

                            StreamReader ler = Program.abrirArquivo(diretorio + @"\" + usuario.getCPF() + @"\relatorio" + conta.getTipo());
                            string linha;
                            do
                            {
                                linha = ler.ReadLine();
                                if (linha != null)
                                {
                                    string[] data = linha.Replace("Consumo: ", "").Replace("Valor:", "").Replace("&", "").Split('/', '\t');

                                    contador++;
                                    totalvalor += Convert.ToDouble(data[5]);
                                    totalconsumo += Convert.ToDouble(data[4]);



                                }

                            } while (linha != null);
                        }
                    }
                } while (linhas != null);

                textBox_Data.Text = "00" + "/" + "00" + "/" + "00";
                textBox_CPF.Text = usuario.getCPF().ToString();
                textBox_Consumo.Text = totalconsumo.ToString();
                textBox_Valor.Text = (totalvalor / contador).ToString();
                textBox_NomeUsu.Text = usuario.getNome();
                label4.Text = "MÉDIA";

            }
            if (conta.getRelatorio().Contains("6"))
            {
                double consumo = 0;
                int dia = 0, mes = 0, ano = 0;
                string linhas;
                do
                {
                    linhas = informa.ReadLine();
                    if (linhas != null)
                    {
                        if (linhas.Contains(usuario.getCPF()))
                        {
                            string diretorio = Directory.GetCurrentDirectory();

                            StreamReader ler = Program.abrirArquivo(diretorio + @"\" + usuario.getCPF() + @"\relatorio" + conta.getTipo());
                            string linha;
                            do
                            {
                                linha = ler.ReadLine();
                                if (linha != null)
                                {
                                    string[] data = linha.Replace("Consumo: ", "").Replace("Valor:", "").Replace("&", "").Split('/', '\t');

                                    if (consumo<Convert.ToDouble(data[4]))
                                    {
                                        dia = Convert.ToInt32(data[0]);
                                        mes = Convert.ToInt32(data[1]);
                                        ano = Convert.ToInt32(data[2]);
                                        conta.setConsumo(Convert.ToDouble(data[4]));
                                        conta.setValor(Convert.ToDouble(data[5]));
                                        consumo = Convert.ToDouble(data[4]);

                                    }


                                }

                            } while (linha != null);
                        }
                    }
                } while (linhas != null);
                textBox_Data.Text = dia + "/" + mes + "/" + ano;
                textBox_CPF.Text = usuario.getCPF().ToString();
                textBox_Consumo.Text = conta.getConsumo().ToString();
                textBox_Valor.Text = conta.getValor();
                textBox_NomeUsu.Text = usuario.getNome();
            }
           /* if (conta.getRelatorio().Contains("4")) {
                RelatorioDoisMeses relatorioAgua = new RelatorioDoisMeses();
                relatorioAgua.ShowDialog();
                Show();
            }*/
            Program.fecharArquivo(informa);
            
        }
        public void relatoriosEnergia(Conta conta, Usuario usuario)
        {
            StreamReader informa = Program.abrirArquivo("USUARIOS");
            string x = conta.getRelatorio();
            if (conta.getRelatorio().Contains("1"))
            {
                int dia = 0;
                int ano = 0;
                int mes = 0;
                string linhas;
                do
                {
                    linhas = informa.ReadLine();
                    if (linhas != null)
                    {
                        if (linhas.Contains(usuario.getCPF()))
                        {
                            string diretorio = Directory.GetCurrentDirectory();

                            StreamReader ler = Program.abrirArquivo(diretorio + @"\" + usuario.getCPF() + @"\relatorio" + conta.getTipo());
                            string linha;
                            do
                            {
                                linha = ler.ReadLine();
                                if (linha != null)
                                {
                                    string[] data = linha.Replace("Consumo: ", "").Replace("Valor:", "").Replace("&", "").Split('/', '\t');

                                    if (Convert.ToInt32(data[2]) > ano || (Convert.ToInt32(data[2]) == ano && Convert.ToInt32(data[1]) > mes) || (Convert.ToInt32(data[2]) == ano && Convert.ToInt32(data[1]) == mes && Convert.ToInt32(data[0]) > dia))
                                    {
                                        dia = Convert.ToInt32(data[0]);
                                        mes = Convert.ToInt32(data[1]);
                                        ano = Convert.ToInt32(data[2]);
                                        conta.setConsumo(Convert.ToDouble(data[4]));
                                        conta.setValor(Convert.ToDouble(data[5]));

                                    }


                                }

                            } while (linha != null);
                        }
                    }
                } while (linhas != null);
                textBox_Data.Text = dia + "/" + mes + "/" + ano;
                textBox_CPF.Text = usuario.getCPF().ToString();
                textBox_Consumo.Text = conta.getConsumo().ToString();//droga
                textBox_Valor.Text = conta.getValor();
                textBox_NomeUsu.Text = usuario.getNome();
            }
            if (conta.getRelatorio().Contains("2"))
            {
                string linhas;
                double totalvalor = 0, totalconsumo = 0;
                do
                {
                    linhas = informa.ReadLine();
                    if (linhas != null)
                    {
                        if (linhas.Contains(usuario.getCPF()))
                        {
                            string diretorio = Directory.GetCurrentDirectory();

                            StreamReader ler = Program.abrirArquivo(diretorio + @"\" + usuario.getCPF() + @"\relatorio" + conta.getTipo());
                            string linha;
                            do
                            {
                                linha = ler.ReadLine();
                                if (linha != null)
                                {
                                    string[] data = linha.Replace("Consumo: ", "").Replace("Valor:", "").Replace("&", "").Split('/', '\t');


                                    totalvalor += Convert.ToDouble(data[5]);
                                    totalconsumo += Convert.ToDouble(data[4]);



                                }

                            } while (linha != null);
                        }
                    }
                } while (linhas != null);
                textBox_Data.Text = "00" + "/" + "00" + "/" + "00";
                textBox_CPF.Text = usuario.getCPF().ToString();
                textBox_Consumo.Text = totalconsumo.ToString();
                textBox_Valor.Text = totalvalor.ToString();
                textBox_NomeUsu.Text = usuario.getNome();
            }
            if (conta.getRelatorio().Contains("3"))
            {
                string linhas;
                double totalvalor = 0, totalconsumo = 0;
                do
                {
                    linhas = informa.ReadLine();
                    if (linhas != null)
                    {
                        if (linhas.Contains(usuario.getCPF()))
                        {
                            string diretorio = Directory.GetCurrentDirectory();

                            StreamReader ler = Program.abrirArquivo(diretorio + @"\" + usuario.getCPF() + @"\relatorio" + conta.getTipo());
                            string linha;
                            do
                            {
                                linha = ler.ReadLine();
                                if (linha != null)
                                {
                                    string[] data = linha.Replace("Consumo: ", "").Replace("Valor:", "").Replace("&", "").Split('/', '\t');


                                    totalvalor += Convert.ToDouble(data[5]);
                                    totalconsumo += Convert.ToDouble(data[4]);



                                }

                            } while (linha != null);
                        }
                    }
                } while (linhas != null);
                if (usuario.getImovel().ToUpper() == "COMERCIAL")
                {
                    textBox_Data.Text = "00" + "/" + "00" + "/" + "00";
                    textBox_CPF.Text = usuario.getCPF().ToString();
                    textBox_Consumo.Text = totalconsumo.ToString();
                    textBox_Valor.Text = (totalvalor / 1.2195).ToString();
                    textBox_NomeUsu.Text = usuario.getNome();
                }
                else
                {
                    textBox_Data.Text = "00" + "/" + "00" + "/" + "00";
                    textBox_CPF.Text = usuario.getCPF().ToString();
                    textBox_Consumo.Text = totalconsumo.ToString();
                    textBox_Valor.Text = (totalvalor / 1.4285).ToString();
                    textBox_NomeUsu.Text = usuario.getNome();


                }
            }
            if (conta.getRelatorio().Contains("5"))
            {
                string linhas;
                int contador = 0;
                double totalvalor = 0, totalconsumo = 0;
                do
                {
                    linhas = informa.ReadLine();
                    if (linhas != null)
                    {
                        if (linhas.Contains(usuario.getCPF()))
                        {
                            string diretorio = Directory.GetCurrentDirectory();

                            StreamReader ler = Program.abrirArquivo(diretorio + @"\" + usuario.getCPF() + @"\relatorio" + conta.getTipo());
                            string linha;
                            do
                            {
                                linha = ler.ReadLine();
                                if (linha != null)
                                {
                                    string[] data = linha.Replace("Consumo: ", "").Replace("Valor:", "").Replace("&", "").Split('/', '\t');

                                    contador++;
                                    totalvalor += Convert.ToDouble(data[5]);
                                    totalconsumo += Convert.ToDouble(data[4]);


                                }

                            } while (linha != null);
                        }
                    }
                } while (linhas != null);

                textBox_Data.Text = "00" + "/" + "00" + "/" + "00";
                textBox_CPF.Text = usuario.getCPF().ToString();
                textBox_Consumo.Text = totalconsumo.ToString();
                textBox_Valor.Text = (totalvalor / contador).ToString();
                textBox_NomeUsu.Text = usuario.getNome();
                label4.Text = "MÉDIA";


            }
            if (conta.getRelatorio().Contains("6"))
            {
                double consumo = 0;
                int dia = 0, mes = 0, ano = 0;
                string linhas;
                do
                {
                    linhas = informa.ReadLine();
                    if (linhas != null)
                    {
                        if (linhas.Contains(usuario.getCPF()))
                        {
                            string diretorio = Directory.GetCurrentDirectory();

                            StreamReader ler = Program.abrirArquivo(diretorio + @"\" + usuario.getCPF() + @"\relatorio" + conta.getTipo());
                            string linha;
                            do
                            {
                                linha = ler.ReadLine();
                                if (linha != null)
                                {
                                    string[] data = linha.Replace("Consumo: ", "").Replace("Valor:", "").Replace("&", "").Split('/', '\t');

                                    if (consumo < Convert.ToDouble(data[4]))
                                    {
                                        dia = Convert.ToInt32(data[0]);
                                        mes = Convert.ToInt32(data[1]);
                                        ano = Convert.ToInt32(data[2]);
                                        conta.setConsumo(Convert.ToDouble(data[4]));
                                        conta.setValor(Convert.ToDouble(data[5]));
                                        consumo = Convert.ToDouble(data[4]);

                                    }


                                }

                            } while (linha != null);
                        }
                    }
                } while (linhas != null);
                textBox_Data.Text = dia + "/" + mes + "/" + ano;
                textBox_CPF.Text = usuario.getCPF().ToString();
                textBox_Consumo.Text = conta.getConsumo().ToString();
                textBox_Valor.Text = conta.getValor();
                textBox_NomeUsu.Text = usuario.getNome();
            }
    /*        if (conta.getRelatorio().Contains("4"))
            {
                RelatorioDoisMeses relatorioAgua = new RelatorioDoisMeses();
                relatorioAgua.ShowDialog();
                Show();
            }

    */

            Program.fecharArquivo(informa);



        }

        private void Fechar_botao_Click(object sender, EventArgs e)
        {
            Close();
            
        }
        
    }
}
