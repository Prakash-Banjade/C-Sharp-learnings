using System;

class NameCollection {
    private string[] names = new string[5]; // Array to hold names

    // Indexer definition
    public string this[int index] {
        get {
            if (index >= 0 && index < names.Length)
                return names[index];
            else
                throw new IndexOutOfRangeException("Invalid index");
        }
        set {
            if (index >= 0 && index < names.Length)
                names[index] = value;
            else
                throw new IndexOutOfRangeException("Invalid index");
        }
    }
}

class Program {
    static void Main() {
        NameCollection nameCollection = new NameCollection();

        // Setting values using the indexer
        nameCollection[0] = "Prakash";
        nameCollection[1] = "Banjade";

        // Getting values using the indexer
        Console.WriteLine(nameCollection[0]);
        Console.WriteLine(nameCollection[1]);
    }
}
