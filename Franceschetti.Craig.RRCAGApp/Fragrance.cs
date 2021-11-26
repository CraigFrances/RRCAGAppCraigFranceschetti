using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Franceschetti.Craig.RRCAGApp
{
    public class Fragrance
    {
        public string FragranceDescription
        {
            get;
        }

        public decimal FragrancePrice
        {
            get;
        }


        public Fragrance(string fragrance, decimal fragrancePrice)
        {
            this.FragranceDescription = fragrance;
            this.FragrancePrice = fragrancePrice;
        }
    }
}
