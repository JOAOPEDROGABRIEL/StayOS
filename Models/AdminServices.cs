using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StayOS.Models.Interface;

namespace StayOS.Models.Services
{
    public class AdminServices
    {
        public static void MenuAdmin(string Nome, string Login, string Senha, string CPF)
        {
            bool menuEnabled = true;
            while (menuEnabled)
            {
                try
                {
                    VisualInterfaces.Logo();
                    VisualInterfaces.MenuAdmin(Nome);
                    string menuOption = Console.ReadLine();

                    switch (menuOption)
                    {
                        case "1":
                        break;

                        case "2":
                        break;

                        case "3":
                        break;

                        case "4":
                        break;

                        case "0":
                        break;

                        default:
                        break;
                    }
                }
                catch (ArgumentNullException)
                {
                    throw new ArgumentException("Valor Inválido>>>");
                }
            }

        }
    }
}