using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;

namespace GDRLauncher
{
    class Program
    {




        static void Main(string[] args)
        {
            
            Bot.InitialSetup();
            Bot.BotLogic();
        }
    }
}