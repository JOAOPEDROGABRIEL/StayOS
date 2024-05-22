using StayOS.Models.VisualInterfaces;
using StayOS.Models.Services;

namespace StayOS.Main
{
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
                    Console.WriteLine("Valor Inválido");
                }
                catch (Exception)
                {
                    Console.WriteLine("Valor Inválido");
                }
                }
        }
    }
}