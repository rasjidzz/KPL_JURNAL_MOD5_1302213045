using MODUL5_1302213045;

class mainprogram
{
    static void Main(string[] args)
    // 1302213045
    {
        // 13 + 02 + 21 = 36
        Penjumlahan<float> penjumlahan = new Penjumlahan<float>();
        Console.WriteLine(penjumlahan.JumlahTigaAngka(13, 02, 21));

        SimpleDataBase<int> database = new SimpleDataBase<int>();
        database.AddNewData(13);
        database.AddNewData(02);
        database.AddNewData(21);
        database.AddNewData(30);
        database.AddNewData(45);
        database.printalldata();
    }
}