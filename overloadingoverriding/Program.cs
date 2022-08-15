// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
 method overloading means same

method name with different signatures
in the same class
 
 */
Manager m;

public class Employee
{
    public string Name { get; set; }
    public string Address { get; set;}  
}

public class Manager: Employee
{
    // overriding
    public void Management()
    {

    }
    // same method name with different 
    // signature
    public void Management(int id)
    {

    }

    // same method name with different 
    // signature
    public void Management(string Name)
    {

    }
}
