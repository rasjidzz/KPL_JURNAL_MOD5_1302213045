using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL5_1302213045
{
    internal class Penjumlahan <T>
    {
        public T JumlahTigaAngka(T bil1, T bil2, T bil3)
        {
            dynamic data = (dynamic)bil1 + (dynamic)bil2 + (dynamic)bil3;
            return data;
        }
    }
}
