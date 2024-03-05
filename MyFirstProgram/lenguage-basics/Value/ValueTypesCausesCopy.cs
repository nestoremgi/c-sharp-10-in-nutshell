public class ValueTypesCausesCopy
{
    public static void ShowHowValueTypesCausesCopies()
    {
        //If we create a Point instance
        Point p1 = new Point();
        p1.X = 7;
        //And the we create other one and assigned p1, this create a copy 
        Point p2 = p1;

        Console.WriteLine($"Original struct  p1.X:{p1.X}");
        Console.WriteLine($"Assigned struct p1 to p2, create a copy of p1, so p2.X:{p2.X}");

        p1.X = 9;
        
        Console.WriteLine($"Value after change p1.X: {p1.X}");
        Console.WriteLine($"Assigned struct p2, doesnt chage cause it's a copy, p2.X:{p2.X}");
    }
}