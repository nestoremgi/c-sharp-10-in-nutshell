public class UnitConverter
{
    int ratio; //field data member
    public UnitConverter(int unitRatio) //constructor function member 
    {
        ratio = unitRatio;
    }

    public int Convert(int unit) //Method function member
    {
        return unit * ratio;
    }
}