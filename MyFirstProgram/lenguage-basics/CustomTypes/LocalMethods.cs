class LocalMethods
{
    public static void Method()
    {
      int x = 3;
      void LocalMethods()
      {
        Console.WriteLine($"This is a var printed from Local Method: {x}");
      }

      LocalMethods();  
    }
}