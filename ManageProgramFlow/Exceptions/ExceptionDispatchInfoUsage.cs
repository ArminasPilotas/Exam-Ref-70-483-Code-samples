using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.Exceptions
{
    public class ExceptionDispatchInfoUsage
    {
        public static void ExceptionDispatchExample()
        {
            ExceptionDispatchInfo possibleException = null;

            try
            {
                string s = Console.ReadLine();
                int.Parse(s); //throws FormatException
            }
            catch (FormatException ex)
            {
                possibleException = ExceptionDispatchInfo.Capture(ex);
            }

            if (possibleException != null) // can be handled outside catch/finally blocks
            {
                possibleException.Throw();
            }
        }
    }
}
