namespace WhatsappConsole
{
    public class Contato
    {
        //PascalCase começa com a primeira letra maiuscula e as demais letras de inicio de palavra maiusculas tambem.
        //normalmente utilizado em propriedades.

        public string Nome { get; set; }
        public string Telefone { get; set; }

        //metodo construtor para contato com argumentos de nome e telefone
        public Contato(string _nome, string _telefone){

            this.Nome = _nome;
            this.Telefone = _telefone;
            
        }
        

    }
}