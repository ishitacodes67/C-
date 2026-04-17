// Program to demonstrate indexers 
using System;
class MyCollection
{
    private int[] data = new int[10];

    // Indexer to access elements in the collection
    public int this[int index]
    {
        get
        {
            if (index < 0 || index >= data.Length)
                throw new IndexOutOfRangeException("Index out of range.");
            return data[index];
        }
        set
        {
            if (index < 0 || index >= data.Length)
                throw new IndexOutOfRangeException("Index out of range.");
            data[index] = value;
        }
    }
}   