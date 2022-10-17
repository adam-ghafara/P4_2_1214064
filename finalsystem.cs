using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214064
{
    internal class finalsystem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama-nama Mobil!");
            Console.WriteLine("Pilih Tier?");
            Console.WriteLine("Tier 1");
            Console.WriteLine("Tier 2");
            Console.WriteLine("Tier 3");
            int tiers = int.Parse(Console.ReadLine());

            switch (tiers)
            {
                case 1: Console.WriteLine("Tier 1"); Console.WriteLine("Berikut Mobil-mobil dalam tier ini: ");
                    car_tier1 ptier1_1 = new car_tier1("Honda Civic Type R", 150000000);
                    car_tier1 ptier1_2 = new car_tier1("Ford Fiesta", 120000000);
                    car_tier1 ptier1_3 = new car_tier1("Datsun 240z", 300000000);
                    car_tier1 ptier1_4 = new car_tier1("Toyota Corolla Levin AE86", 440000000);
                    Console.WriteLine("+ {0} : Rp.\"{1}\"", ptier1_1.CarName1, ptier1_2.CarPrice1);
                    Console.WriteLine("+ {0} : Rp.\"{1}\"", ptier1_2.CarName1, ptier1_2.CarPrice1);
                    Console.WriteLine("+ {0} : Rp.\"{1}\"", ptier1_3.CarName1, ptier1_3.CarPrice1);
                    Console.WriteLine("+ {0} : Rp.\"{1}\"", ptier1_4.CarName1, ptier1_4.CarPrice1);

                    break;

                case 2: Console.WriteLine("Tier 2"); Console.WriteLine("Berikut Mobil-mobil dalam tier ini: ");
                    car_tier2 ptier2_1 = new car_tier2("Mazda RX-7 FD3S", 455000000);
                    car_tier2 ptier2_2 = new car_tier2("Nissan Skyline R34 GT-R", 455000000);
                    car_tier2 ptier2_3 = new car_tier2("Chevrolet Corvette Z06", 455000000);
                    car_tier2 ptier2_4 = new car_tier2("Mitsubishi Lancer Evolution IX MR GSR", 650000000);
                    Console.WriteLine("+ {0} : Rp.\"{1}\"", ptier2_1.CarName2, ptier2_1.CarPrice2);
                    Console.WriteLine("+ {0} : Rp.\"{1}\"", ptier2_2.CarName2, ptier2_2.CarPrice2);
                    Console.WriteLine("+ {0} : Rp.\"{1}\"", ptier2_3.CarName2, ptier2_3.CarPrice2);
                    Console.WriteLine("+ {0} : Rp.\"{1}\"", ptier2_4.CarName2, ptier2_4.CarPrice2);

                    break;

                case 3: Console.WriteLine("Tier 3"); Console.WriteLine("Berikut Mobil-mobil dalam tier ini: ");
                    car_tier3 ptier3_1 = new car_tier3("Lamborghini Huracan", 999000000);
                    car_tier3 ptier3_2 = new car_tier3("Ferrari 458", 999000000);
                    car_tier3 ptier3_3 = new car_tier3("Acura NSX", 750000000);
                    Console.WriteLine("+ {0} : Rp.\"{1}\"", ptier3_1.CarName3, ptier3_1.CarPrice3);
                    Console.WriteLine("+ {0} : Rp.\"{1}\"", ptier3_2.CarName3, ptier3_2.CarPrice3);
                    Console.WriteLine("+ {0} : Rp.\"{1}\"", ptier3_3.CarName3, ptier3_3.CarPrice3);

                    break;
                default: Console.WriteLine("Pilih Tier?"); break;
            }

        }
    }
}
