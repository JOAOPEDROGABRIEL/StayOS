using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StayOS.Models.Interface
{
    public class VisualInterfaces
    {
        public static void Logo()
        {
            Console.Clear();
            Console.WriteLine(@"
             ░▒▓███████▓▒░░▒▓████████▓▒░░▒▓██████▓▒░ ░▒▓█▓▒░░▒▓█▓▒░       ░▒▓██████▓▒░  ░▒▓███████▓▒░ 
            ░▒▓█▓▒░          ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░        
            ░▒▓█▓▒░          ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░░▒▓█▓▒░        
             ░▒▓██████▓▒░    ░▒▓█▓▒░   ░▒▓████████▓▒░ ░▒▓██████▓▒░       ░▒▓█▓▒░░▒▓█▓▒░ ░▒▓██████▓▒░  
                   ░▒▓█▓▒░   ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░   ░▒▓█▓▒░          ░▒▓█▓▒░░▒▓█▓▒░       ░▒▓█▓▒░ 
                   ░▒▓█▓▒░   ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░   ░▒▓█▓▒░          ░▒▓█▓▒░░▒▓█▓▒░       ░▒▓█▓▒░ 
            ░▒▓███████▓▒░    ░▒▓█▓▒░   ░▒▓█▓▒░░▒▓█▓▒░   ░▒▓█▓▒░           ░▒▓██████▓▒░ ░▒▓███████▓▒░ 
");
        }

        public static void MainMenu()
        {
Console.WriteLine(@"
    __________________________________________________________________________________________________________

                            Bem Vindo ao StayOS, Controle Total do seu Hotel

    ----------------------------------------------------------------------------------------------------------

                Digite a operação que deseja realizar:

                1 - Entrar
                2 - AboutMe

                0 - Encerrar

    ----------------------------------------------------------------------------------------------------------

>>>");
        }

        public static void LoginStepOne()
        {
            Console.Clear();
            Console.WriteLine(@$"
    -----------------------------------------------
    
            Digite Seu Login >>
    
    -----------------------------------------------

>>>");
        }

        public static void LoginStepTwo()
        {
            Console.Clear();
            Console.WriteLine(@$"
    -----------------------------------------------
    
            Digite Sua Senha >>
    
    -----------------------------------------------

>>>");
        }

        public static void Redirect(string Metodo)
        {
            Console.WriteLine(@$"
        -----------------------------------------
           Redirecionando para {Metodo}
        -----------------------------------------

Pressione Enter para Prosseguir>>>");
            Console.ReadLine();
        }

        public static void BackMenu(string Metodo)
        {
            Console.WriteLine(@$"
        -----------------------------------------
           Voltando para {Metodo}
        -----------------------------------------

Pressione Enter para Prosseguir>>>");
            Console.ReadLine();
        }

        public static void MenuAdmin(string Apelido)
        {
Console.WriteLine(@$"
    __________________________________________________________________________________________________________

                            Bem Vindo {Apelido}!

    ----------------------------------------------------------------------------------------------------------

                Digite a operação que deseja realizar:

                1 - Cadastrar Reserva
                2 - Cadastrar Suíte
                3 - Cadastrar Funcionário
                4 - Painel de Gerência

                0 - Voltar

    ----------------------------------------------------------------------------------------------------------

>>>");
        }

        public static void MenuStaffHL(string Apelido)
        {
Console.WriteLine(@$"
    __________________________________________________________________________________________________________

                            Bem Vindo {Apelido}!

    ----------------------------------------------------------------------------------------------------------

                Digite a operação que deseja realizar:

                1 - Solicitar Manutenção
                2 - Solicitar Materiais
                3 - Andamento de Solicitações

                0 - Voltar

    ----------------------------------------------------------------------------------------------------------

>>>");
        }

        public static void MenuStaffLL(string Apelido)
        {
Console.WriteLine(@$"
    __________________________________________________________________________________________________________

                            Bem Vindo {Apelido}!

    ----------------------------------------------------------------------------------------------------------

                Digite a operação que deseja realizar:

                1 - Cadastrar Reserva
                2 - Solicitar Manutenção
                3 - Andamento de Manutenção

                0 - Voltar

    ----------------------------------------------------------------------------------------------------------

>>>");
        }
    }
}