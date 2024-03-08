using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hidden_tear.Tools
{
    internal class Windows
    {
        public static void RunningOnce()
        {
            using (Mutex mut = new Mutex(false))
            {

            }
        }


        public static void Registry(string path, string var, string val)
        {

        }
    }
}
