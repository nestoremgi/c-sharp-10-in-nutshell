using System.IO.Compression;

public class TypesBasics {
    public static void PrintPredifinedTypes() 
    {
        Console.WriteLine("Predefined Types  30 - 31 pag.");
        int x = 12 * 30;
        Console.WriteLine($"int -> 12 * 30 = {x}");

        string message = "Hello world";
        string upperMessage = message.ToUpper();
        Console.WriteLine($"string -> Applied some basic string methods ToUpper {upperMessage}");

        int y = 2022;
        message = message + y.ToString();
        Console.WriteLine($"string -> Applied ToString to y  -> {message}");

        bool simpleVar = false;
        if(simpleVar)
            Console.WriteLine("This will not print");
        Console.WriteLine($"bool simpleVar {simpleVar}  is used in some basic validation with which result false");
        
        int z = 5000;
        bool lessThanAMile = x < 5200;
        if (lessThanAMile)
            Console.WriteLine("This will print");
        Console.WriteLine($"bool z {z}  is used in some basic validation which result true");
        

    }

}