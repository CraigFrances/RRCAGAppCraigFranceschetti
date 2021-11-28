using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Franceschetti.Craig.RRCAGApp
{
    class CarWashServices
    {
        public string Description
        {
            get;
        }

        public decimal Price
        {
            get;
        }

        public CarWashServices(string description, decimal price)
        {
            this.Description = description;
            this.Price = price;
        }
    }
}
