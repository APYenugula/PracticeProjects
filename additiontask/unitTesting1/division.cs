using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitTesting1
{
    public class division
    {
        public int divi(int a,int b)
        
       {
            
                try
                {
                checked
                {
                    return a / b;

                }
      
                }
               catch(Exception ex)
               {
                throw new Exception(ex.Message);

               }
           
            
        }

    }
}
