namespace Animal //Panda is defined in a namespace
{
    public class Panda
    {
        public string Name;
        public static int Population; 
        public Panda(string name){
            Name = name;
            Population += 1;
        }
    }
}