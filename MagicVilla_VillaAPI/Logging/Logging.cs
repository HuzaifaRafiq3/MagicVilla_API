using MagicVilla_VillaAPI.Loging;

namespace MagicVilla_VillaAPI.Logging
{
    public class Logging : ILogging
    {
        public void Log(string message, string type)
        {
            if(type == "error")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Error - " + message);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                if(type == "warning")
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Error - " + message);
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                else
                {
                    Console.WriteLine(message);
                }

            }
        }
    }
}
