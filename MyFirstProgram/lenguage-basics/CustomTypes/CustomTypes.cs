public class CustomTypes
{
    public static void PrintedCustomTypes()
    {
        Console.WriteLine($"It's created a custom type called UnitCoverter, initalize 2 instances");
        UnitConverter feetToInchesConverter = new UnitConverter(12);
        UnitConverter milesToFeetConverter = new UnitConverter(5280);

        Console.WriteLine($"Converts Feets to inches 1 feet is equivalente to 12 inches: {feetToInchesConverter.Convert(30)}");
        Console.WriteLine(feetToInchesConverter.Convert(100));
        Console.WriteLine($"Converts miles to inches is equivalente to 12 inches: {feetToInchesConverter.Convert(30)}");

        Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));
    }
}