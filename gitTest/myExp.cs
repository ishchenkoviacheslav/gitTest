using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitTest
{
   public class myExp:SystemException     
    {
        IntPtr ptr = IntPtr.Zero;
        public myExp(IntPtr p)
        {
            ptr = p;
        }
    }
}
