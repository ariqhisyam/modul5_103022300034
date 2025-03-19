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

class Program
{
    static void Main()
    {
        SimpleDataBase<int> intDB = new SimpleDataBase<int>();
        intDB.AddNewData(12);
        intDB.AddNewData(34);
        intDB.AddNewData(56);
        intDB.PrintAllData();
        SimpleDataBase<string> stringDB = new SimpleDataBase<string>();
        
        stringDB.PrintAllData();
    }
}