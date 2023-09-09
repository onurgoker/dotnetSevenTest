using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Lambda;

namespace MyApp
{
    public class Function
    {
        public static void Main()
        {
            var lambda = new Lambda();
            lambda.FunctionHandler("hello world");
        }
    }
}
