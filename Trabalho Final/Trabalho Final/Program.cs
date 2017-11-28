using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Trabalho_Final.Relatorios;
using Trabalho_Final.Relatorios;
using System.Windows.Forms;

namespace Trabalho_Final
{
    static class Program
    {
        static public Contas.Conta contaRelatorio;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuPrincipal());// ELE RODA UM ESCOLHA
            
        }




















       public static StreamReader abrirArquivo(string nome) {
            FileStream arq = new FileStream(nome +".txt", FileMode.Open); 
            StreamReader abrir = new StreamReader(arq);
            return abrir;
        }
        public static StreamWriter criarArquivo(string nome)
        {
            FileStream arq = new FileStream(nome +".txt", FileMode.Create);
            StreamWriter abrir = new StreamWriter(arq);
            return abrir;
        }
        public static StreamWriter escreverArquivo(string nome)
        {
            FileStream arq = new FileStream(nome +".txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arq);
            return escreve;
        }
        public static void fecharArquivo(FileStream arquivo)
        {
            arquivo.Close();
        }
        public static void fecharArquivo(StreamReader arquivo)
        {
            arquivo.Close();
        }
        public static void fecharArquivo(StreamWriter arquivo)
        {
            arquivo.Close();
        }
        
    }
}
