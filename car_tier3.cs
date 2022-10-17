using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214064
{
    internal class car_tier3 : car_tiering
    {
        protected int carPrice;

        public car_tier3(string name, int price) : base(name, price)
        {
            this.CarName3 = name;
            this.carPrice = price;
        }
    }
}
