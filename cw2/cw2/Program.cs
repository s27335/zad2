public class Program{

    public static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Modification1");
        Console.WriteLine("Modification2");
        Console.WriteLine("Modification3");
    }

    
    public static double Avg(int[] tab)
    {
        double suma=0;
        for (int i = 0; i < tab.Length; i++)
        {
            suma += tab[i];
        }
        
        return suma/tab.Length;   
    }

}