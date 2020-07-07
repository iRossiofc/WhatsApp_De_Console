namespace WhatsappConsole
{
    public class Mensagem
    {
        public string Texto { get; set; }
        //contato virou uma composição de mensagem, no qual não da pra enviar uma mensagem sem ter um contato
        public Contato Destinatario { get; set; }

        //enviar mensagens para um contato
        public string Enviar(){
            return $"Para: {Destinatario.Nome} \n Mensagem: {Texto}";
        }
    }
}