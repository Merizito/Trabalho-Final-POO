using System;
using System.IO;    
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Final.Usuarios
{
    public class Usuario
    {
        string nome;
        string CPF;
        public string getNome() {
            return this.nome;
        }
        public void setNome(string nome) {
            this.nome = nome;
        }
        public string getCPF()
        {
            return this.CPF;
        }
        public void setCPF(string CPF)
        {
            this.CPF = CPF;
        }
        static public bool Valida(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                try
                {
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
                }
                catch (FormatException erro)
                {
                    MessageBox.Show(erro.Message);
                    return false;
                }
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
        static public bool ProcuraCPF(string cpf) {
            StreamReader ler = Program.abrirArquivo("USUARIOS");
            string arquivo = ler.ReadToEnd();
            string CPF = cpf.Replace("/", "").Replace(".","").Replace("-","").Replace(" ","");
                if (arquivo.Contains(CPF))
                {
                    Program.fecharArquivo(ler);
                    return true;
                }
            Program.fecharArquivo(ler);
            return false;
        }


        static public bool ProcuraCadastro(string cpf, string nome)
        {
            StreamReader ler = Program.abrirArquivo("USUARIOS");
            string CPF = cpf.Replace("/", "").Replace(".", "").Replace("-", "").Replace(" ", "");
            string linha;
            nome = nome.ToUpper();
            do
            {
                linha = ler.ReadLine();
                if (linha != null)
                {
                    linha = linha.ToUpper();
                    if (linha.Contains(CPF) && linha.Contains(nome))
                    {
                        Program.fecharArquivo(ler);
                        return true;
                    }
                }
            } while (linha != null);
            Program.fecharArquivo(ler);
            return false;
        }
    }
}

