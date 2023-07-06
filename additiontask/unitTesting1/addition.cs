using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitTesting1
{
    
        public class Addition
        {
            public int add(int a, int b)
            {
            try
            {
                checked
                {
                    int res = a + b;
                    return res;

                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
               
            }
        }
    
}
