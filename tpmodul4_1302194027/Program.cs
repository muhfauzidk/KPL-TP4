using System;
using System.Collections;
using System.Collections.Generic;

public class HaloGeneric
{
    public void SapaUser<T>(T print)
    {
        string x = Console.ReadLine();
        Console.WriteLine(print + x);
    }
}

public class Program
{
    public static void Main()
    {
        HaloGeneric n = new HaloGeneric();
        n.SapaUser<string>("Halo user ");  
    }
}
