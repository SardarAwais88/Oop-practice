// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Explain inheritance
// inheritance defines
// a parent child relationship
Manager m;
public class Employee
{
    public string name { get; set; }
    public string Address { get; set; }

     
    public void validate()
    {
        checkname();
        checkaddress();
    }


    private void checkname()
    {

    }
    private void checkaddress()
    {

    }
}

// manager class inherit Employee 
// so it can access its: properties
public class Manager : Employee
{
    public void Management()
    {
        manageclass();
        ManageStudent();
    }

    private void manageclass()
    {

    }

    public void ManageStudent()
    {

    }
    }
