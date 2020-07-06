using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WhatsappConsole
{
    //herança da interface da Agenda (IAgenda)
    public class Agenda : IAgenda
    {

        private const string PATH = "Database/Contato.csv";
        List<Contato> contato = new List<Contato>();
        

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
            throw new NotImplementedException();
        }

        public void Listar()
        {
            throw new NotImplementedException();
        }

        private string PrepararLinhaCSV(Contato contato)
        {
            return $"{contato.Nome};{contato.Telefone}";
        }
        
        
    }
}