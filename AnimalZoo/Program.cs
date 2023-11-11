using AnimalZoo.Services;

class Program
{
    static void Main()
    {
        string dataFilePath = "Data/ZooData.json";
        ZooService zooService = new ZooService(dataFilePath);

        // Önceki kodu buraya ekleyin

        // Eğer yeni hayvanlar veya bakıcılar eklediyseniz, aşağıdaki gibi kaydedebilirsiniz:
        // zooService.SaveZoo(myZoo);
    }
}
