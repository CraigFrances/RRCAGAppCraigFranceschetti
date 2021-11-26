using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Franceschetti.Craig.RRCAGApp
{
    class Package
    {
        public string PackageDescription
        {
            get;
        }

        public decimal PackagePrice
        {
            get;
        }

        public Package(string description, decimal price)
        {
            this.PackageDescription = description;
            this.PackagePrice = price;
        }
    }
}
