using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_1302210036
{
    internal class Penjumlahan
    {

        public void JumlahTigaAngka <T>(T data1, T data2, T data3)
        {
            T temp;
            temp = (dynamic)data1 + (dynamic)data2 + (dynamic)data3;
            Console.WriteLine("Hasil Penjumlahannya Adalah: " + temp);
        }
    }
}
