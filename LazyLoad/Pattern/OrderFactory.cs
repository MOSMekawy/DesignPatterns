using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoad.Pattern
{
    // similar to lazy load feature in ef core
    public class OrderFactory
    {
        public Order CreateOrder()
        {
            return new OrderProxy();
        }
    }
}
