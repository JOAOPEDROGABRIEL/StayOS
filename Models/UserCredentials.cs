using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StayOS.Models.Interface;
using StayOS.Models.Data;
using Newtonsoft.Json;
using StayOS.Models.Services;
using System.ComponentModel.DataAnnotations.Schema;

namespace StayOS.Models.Users
{
    public class UserCredentials
    {
        private string CompleteName { get; set; }
        private string Cargo { get; set; }
        private string Login { get; set; }
        private string Password { get; set; }
        private string CPF { get; set; }

            public static (string Nome, string Login, string Senha, string Cargo) SetAdmin()
            {
                List<UserCredentials> Users = new List<UserCredentials>();
                UserCredentials User = new UserCredentials() 
                {
                    CompleteName = "Administrator", 
                    Login = "admin", 
                    Password = "adminuserlogin", 
                    Cargo = "Administrador"
                };
                return (User.CompleteName, User.Login, User.Password, User.Cargo);
            }
        public static (string Nome, string Login, string Senha, string Cargo) LoginValidation()
        {
            (string NomeCarregado, string LoginCarregado, string SenhaCarregado, string CargoCarregado) SetAdmin();
            string Login = "";
            string Senha = "";
            try
            {
                VisualInterfaces.LoginStepOne();
                Login = Console.ReadLine();

                VisualInterfaces.LoginStepTwo();
                Senha = Console.ReadLine();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine(@"
Valor Inválido >>>");
            }

            if (Login == User.LoginCarregado && Senha == User.SenhaCarregado)
            {
                return (User.NomeCarregado, User.LoginCarregado, User.SenhaCarregado, User.CargoCarregado);
            }
            else
            {
                return ("", "", "", "none");
            }
        }

    }
}