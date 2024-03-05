public class ImplicitAndExplicit
{
    public static void PrintConversions()
    {
        int x = 12345;
        //x can be performece implicit convertions for gratest data type like long
        long y = x;
        //But it cannot perform convertion for short datatypes for example for short types it must be explicit use cast
        short z = (short)x;
    }
}