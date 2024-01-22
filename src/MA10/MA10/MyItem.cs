namespace MA10;

public class MyItem
{
    public string Name { get; set; }
    public int Age { get; set; }

    public static List<MyItem> GetAll()
    {
        List<MyItem> result = new List<MyItem>();
        for (int i = 0; i < 100; i++)
        {
            result.Add(new MyItem { Name = $"Name {i}", Age = i });
        }
        return result;
    }
}
