class Program
{
    static void Main()
    {
        // Example usage
        CustomList<int> customList = new CustomList<int>(capacityIncrement: 8);

        customList.Add(1);
        customList.Add(2);
        customList.Add(3);

        Console.WriteLine($"Count: {customList.Count}, Capacity: {customList.Capacity}");

        customList.Remove(2);

        Console.WriteLine($"Count: {customList.Count}, Capacity: {customList.Capacity}");
    }
}