using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHSMarkitProject.CustomeException
{
    public class NoSuitableDriverFound : Exception
    {
        public NoSuitableDriverFound(string msg): base(msg)
        {

        }
    }
}
