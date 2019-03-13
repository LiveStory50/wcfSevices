using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WCF.Service.接口代码实现
{
   public class CanaolServices:ICanaolServices
    {
        public double jia(double x, double y)
        {
            return x + y;
        }

        public double jian(double x, double y)
        {
            return x - y;
        }
    }
}
