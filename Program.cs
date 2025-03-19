using System;


class SimpleDataBase<T> {

    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine(storedData[i] + " was added on " + inputDates[i]);
        }
    }

    

}







    class Pemrosesandata
    {
        public T DapatkanNilaiTerbesar<T>(T angka1, T angka2, T angka3)
        {
            dynamic temp = (dynamic)angka1;
            dynamic temp2 = (dynamic)angka2;
            dynamic temp3 = (dynamic)angka3;
            dynamic terbesar = temp;

            if (temp2 > terbesar)
            {
                terbesar = temp2;
            }
            if (temp3 > terbesar)
            {
                terbesar = temp3;
            }

            return terbesar;




        }
        
        
    }
internal class Program
{
    static void Main()
    {

        Pemrosesandata pemrosesandata = new Pemrosesandata();
        Console.WriteLine("Nilai terbesar adalah : " + pemrosesandata.DapatkanNilaiTerbesar(10.5, 30.5, 22.5));
        SimpleDataBase<int> intDB = new SimpleDataBase<int>();
        intDB.AddNewData(12);
        intDB.AddNewData(34);
        intDB.AddNewData(56);
        intDB.PrintAllData();
        SimpleDataBase<string> stringDB = new SimpleDataBase<string>();
        
        stringDB.PrintAllData();
        
    }
}

