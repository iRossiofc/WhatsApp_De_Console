using System.Collections.Generic;

namespace WhatsappConsole
{
    //interface para Agenda
    public interface IAgenda
    {
        //Dessa forma criamos um tipo de regra de contato, no qual todos os metodos aqui listados terão que ser utilizados na classe agenda
        void Cadastrar ( Contato contato );
        void Excluir( Contato contato );
        List<Contato> Listar();

    }
}