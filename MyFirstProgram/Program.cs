// See https://aka.ms/new-console-template for more information
using Animal; 
using Basics;
//All code is living on  top level statement file

//Show a simple method call
Console.WriteLine(FeetToInches(30));
Console.WriteLine(FeetToInches(100));

int FeetToInches(int feet)
{
    int inches = feet * 12;
    return inches;
}

//Basic data types are called Literals like ints values
Literals.GetLiterals();

//Predifinided datatypes
TypesBasics.PrintPredifinedTypes();

//Custom data types
CustomTypes.PrintedCustomTypes();

//An example of how Custom Types are create, called and how static functions works
Panda p1 = new Panda("Panda 1");
Panda p2 = new Panda("Panda 2");
Console.WriteLine($"Panda Name: {p1.Name}");
Console.WriteLine($"Panda Name: {p2.Name}");
Console.WriteLine($"Panda Population: {Panda.Population}");

//Example of a local method 
LocalMethods.Method();

//Types and conversions
ImplicitAndExplicit.PrintConversions();

ValueTypesCausesCopy.ShowHowValueTypesCausesCopies();

//Value Types and Reference Types
ValueReferenceNotCausesCopies.ShowHowValuesTypesWorksCausesCopies();
