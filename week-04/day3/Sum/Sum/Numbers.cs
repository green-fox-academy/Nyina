using System;
using System.Collections.Generic;
using System.Text;

namespace Sum
{
    public class Numbers
    {
        


        public int SumMethod(List<int> numbers)
        {
            int result = 0;

            foreach (var number in numbers)
            {
                result += number;
                
            }
            //ha bentebb teszem, akkor az első lefutás után abbahagyja
            return result;
        }
    }
}
