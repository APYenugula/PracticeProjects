using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitTesting1
{
    public class subtraction
    {
        
        public int difference(int x, int y)
        {
            try
            {
                checked
                {
                    return x - y;
                }

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }



        }
    }
}
