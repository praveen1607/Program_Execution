using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Execution
{
    public class ProgramOne
    {
        public static void Main(String[] args)   // It gives error saying it have more than one entry point
        {
            Program Pobj = new Program();
            Pobj.One();
        }

    }
}
