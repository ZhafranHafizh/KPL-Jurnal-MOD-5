// See https://aka.ms/new-console-template for more information
class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }
    
    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for(int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i + 1) + " berisi " + storedData[i] + ", yang disimpan pada waktu UTC " + inputDates[i]);
        }
    }
}


class mainProg
{
    static void Main(string[] args)
    {
        SimpleDataBase<int> data = new SimpleDataBase<int>();
        
        data.AddNewData(13);
        data.AddNewData(02);
        data.AddNewData(21);
        data.PrintAllData();
    }
}
