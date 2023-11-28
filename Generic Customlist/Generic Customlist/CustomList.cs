using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CustomList<T>
{
    private List<T> items;
    private int capacityIncrement;

    public CustomList(int initialCapacity = 0, int capacityIncrement = 8)
    {
        this.items = new List<T>(initialCapacity);
        this.capacityIncrement = capacityIncrement;
    }

    public int Count
    {
        get { return items.Count; }
    }

    public int Capacity
    {
        get { return items.Capacity; }
    }

    public void Add(T item)
    {
        items.Add(item);

        if (Count == Capacity)
        {
            items.Capacity += capacityIncrement;
        }
    }

    public T Find(Predicate<T> match)
    {
        return items.Find(match);
    }

    public List<T> FindAll(Predicate<T> match)
    {
        return items.FindAll(match);
    }

    public bool Contains(T item)
    {
        return items.Contains(item);
    }

    public bool Exists(Predicate<T> match)
    {
        return items.Exists(match);
    }

    public bool Remove(T item)
    {
        bool removed = items.Remove(item);

        if (removed && Count + capacityIncrement < Capacity)
        {
            items.Capacity -= capacityIncrement;
        }

        return removed;
    }
}