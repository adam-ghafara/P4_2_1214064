using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214064
{
    internal class car_tier2 : car_tiering
    {
        protected int carPrice;

        public car_tier2(string name, int price): base(name, price)
        {
            this.CarName2 = name;
            this.carPrice = price;
        }
    }
}
