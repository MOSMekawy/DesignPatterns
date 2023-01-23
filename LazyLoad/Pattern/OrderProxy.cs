using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoad.Pattern
{
    public class OrderProxy : Order
    {
        public OrderProxy()
        {
        }

        public override Customer Customer
        {
            get
            {
                // lazy load logic
                if (base.Customer == null)
                    base.Customer = new Customer();

                return base.Customer;
            }
            set
            {
                base.Customer = value;
            }
        }
    }
}
