using System;

namespace WhatsappConsole
{
    class Program
    {
        static void Main(string[] args)
        {
           Agenda agenda = new Agenda();

           Contato Rossi = new Contato("Rossi", "4002-8922");
           agenda.Cadastrar(Rossi);

           Contato pizzaria = new Contato("pizzaria", "98465-6985");
           agenda.Cadastrar(pizzaria);

           Contato pizzaria2 = new Contato("pizzaria2", "98445-4875");
           agenda.Cadastrar(pizzaria2);

            Contato hamburgueria = new Contato("hamburgueria", "98485-6985");
            agenda.Cadastrar(hamburgueria);

           agenda.Excluir(pizzaria2);

           foreach(Contato item in agenda.Listar()){
               System.Console.WriteLine($"nome: {item.Nome}, telefone: {item.Telefone}");
           }

           Mensagem conversa = new Mensagem();
           conversa.Destinatario = hamburgueria;
           conversa.Texto = "vocês vendem hamburguer?";
           System.Console.WriteLine( conversa.Enviar() );


        }
    }
}
