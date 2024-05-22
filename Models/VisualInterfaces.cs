using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StayOS.Models.VisualInterfaces
{
    public class VisualInterfaces
    {
        public static void Logo()
        {
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

        public static void Redirect(string Metodo)
        {
            Console.WriteLine(@$"
        -----------------------------------------
           Redirecionando para {Metodo}
        -----------------------------------------

Pressione Enter para Prosseguir>>>");
            Console.ReadLine();
        }
    }
}