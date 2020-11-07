using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingLanguageEnvironmentforASE
{

    /// <summary>
    /// Class to hold error messages
    /// </summary>
   public static class Messages
    {

        public static string ErrorMessage { get; set; }
        public static void InvalidPenAction()
        {
            ErrorMessage = "\nInvalid Pen Action\n";
        }
        public static void InvalidCommand()
        {
            ErrorMessage = "\nInvalid Command\n";
        }
        
    
    }
}
