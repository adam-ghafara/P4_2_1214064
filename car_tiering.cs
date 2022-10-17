using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214064
{
    internal class car_tiering
    {
        private string carName;
        private int carPrice;

        public car_tiering(string name, int price)
        {
            this.carName = name;
            this.carPrice = price;
        }

        public string CarName1 {
        get {
        return carName;
        }
        set {
        carName = value;
        }
        }
        public int CarPrice1
        {
            get
            {
                return carPrice;
            }
            set
            {
                carPrice = value;
            }
        }
        public string CarName2
        {
            get
            {
                return carName;
            }
            set
            {
                carName = value;
            }
        }
        public int CarPrice2
        {
            get
            {
                return carPrice;
            }
            set
            {
                carPrice = value;
            }
        }
        public string CarName3
        {
            get
            {
                return carName;
            }
            set
            {
                carName = value;
            }
        }
        public int CarPrice3
        {
            get
            {
                return carPrice;
            }
            set
            {
                carPrice = value;
            }
        }
    }
}
