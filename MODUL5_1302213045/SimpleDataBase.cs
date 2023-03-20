using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODUL5_1302213045
{
    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputdates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputdates = new List<DateTime>();
        }
        public void AddNewData(T input)
        {
            this.storedData.Add(input);
            this.inputdates.Add(DateTime.Now);
        }
        public void printalldata()
        {
            
            for (int i = 0; i < this.storedData.Count;i++)
            {
                Console.WriteLine("Data " + (i + 1) + " berisi : " + this.storedData[i] + ", yang disimpan pada waktu UTC : " +
                     inputdates[i]);
            }
        }
    }
}
