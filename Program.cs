using StayOS.Models.Services;
using Newtonsoft.Json;
using StayOS.Models.Users;
using StayOS.Models.Interface;

namespace StayOS.Main
{
    }
    public class Program
    {
        public static void Main (string [] args)
        {
            bool RunProgram = true;
            while (RunProgram)
            {
                string MenuOption;
                Console.Clear();
                VisualInterfaces.Logo();
                VisualInterfaces.MainMenu();
            
                try
                {
                    MenuOption = Console.ReadLine();
                    switch (MenuOption)
                    {
                        case "1": // Login Page
                        VisualInterfaces.Redirect("Login");
                        (string Nome, string Login, string Senha, string Cargo) = UserCredentials.LoginValidation();
                            if (Nome != "" && Login != "" && Senha != "")
                            {
                                VisualInterfaces.Redirect("Menu Principal");
                                if (Cargo == "Administrador")
                                {
                                    AdminServices.MenuAdmin(Nome, Login, Senha);
                                }
                            }
                        break;

                        case "2": // AboutMe Page
                        VisualInterfaces.Redirect("Página AboutMe");
                        break;

                        case "0": // Finish Program
                        RunProgram = false;
                        break;
                    }
                    
                }
                catch (ArgumentNullException)
                {
                    throw new ArgumentException("Valor Inválido");
                }
                catch (Exception)
                {
                    throw new ArgumentException("Valor Inválido");
                }
            }
        }
    }

    public class FirstAccess
    {
        public string firstAccess { get; set; }
        public static void PrimeiroAcesso()
        {
            string json = File.ReadAllText("Models/Arquivos/firstaccess.json");
            string firstAccess = JsonConvert.DeserializeObject<string>(json);

            if (firstAccess != "true")
            {
                firstAccess = "true";
                json = JsonConvert.SerializeObject(firstAccess, Formatting.Indented);
                File.WriteAllText("Models/Arquivos/firstaccess.json", json);
                UserCredentials.SetAdmin();
            }
        }

    }