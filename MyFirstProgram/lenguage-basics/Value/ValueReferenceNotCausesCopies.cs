public class ValueReferenceNotCausesCopies
{
    public static void  ShowHowValuesTypesWorksCausesCopies()
    {
        PointC p1 = new()
        {
            X = 9
        };

        PointC p2 = p1;
        p2.X = 7;

        Console.WriteLine($"Point p1: {p1.X}");
        Console.WriteLine($"Point p2: {p2.X}");

    }
}