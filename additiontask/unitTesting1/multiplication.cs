using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitTesting1
{
    public class multiplication
    {
        public int mul(int a,int b)
        {
            try
            {
                checked
                {
                    return a * b;

                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }
    }
}
