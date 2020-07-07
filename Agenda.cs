using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WhatsappConsole
{
    //herança da interface da Agenda (IAgenda)
    public class Agenda : IAgenda
    {

        private const string PATH = "Database/Contato.csv";
        List<Contato> contatos = new List<Contato>();
        

        public Agenda()
        {   

            // Criando diretorio(Pasta) caso não exista
            string pasta = PATH.Split('/')[0];
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            // Cria o arquivo caso não exista
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public void Cadastrar(Contato contato)
        {
            string[] linha =  { PrepararLinhaCSV(contato) };
            File.AppendAllLines(PATH, linha);
        }

        public void Excluir(Contato contato)
        {
            // Criamos uma lista de linhas para fazer uma espécie de backup 
            // na memória do sistema
            List<string> linhas = new List<string>();

            using(StreamReader arquivo = new StreamReader(PATH))
            {
                string linha;
                while((linha = arquivo.ReadLine()) != null){
                    linhas.Add(linha);
                }
            }

            linhas.RemoveAll(x => x.Contains(contato.Nome));

            ReescreverCSV(linhas);
        }

        public List<Contato> Listar()
        {
            string[] linhas = File.ReadAllLines(PATH);

            foreach(string linha in linhas)
            {
                string[] dado = linha.Split(";");
                contatos.Add(new Contato( dado[0], dado[1]));
            }

            contatos = contatos.OrderBy(z => z.Nome).ToList();

            return contatos;
        }
        

        private string PrepararLinhaCSV(Contato contato)
        {
            return $"{contato.Nome};{contato.Telefone}";
        }

        /// <summary>
        /// Reescreve o CSV
        /// </summary>
        /// <param name="lines">Lista de linhas</param>
        private void ReescreverCSV(List<string> lines){
            // Criamos uma forma de reescrever o arquivo sem as linhas removidas
            using(StreamWriter output = new StreamWriter(PATH))
            {
                foreach(string ln in lines)
                {
                    output.Write(ln+"\n");
                }
            }
        }
       
    }
}