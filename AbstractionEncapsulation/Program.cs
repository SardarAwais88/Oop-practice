// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Employee em1 = new Employee();
Employee em2 = new Employee();
em1.name = "sardar";
em2.name = "Awais";

em1.Address = "trarkhel";
em2.Address = "nerian";
// it is class blue print

// abstraction happens during design phase
/*
what has to be shown public
 */

/*
 during execution developer 
uses Encapsulation to implement abstraction
 */
public class Employee
{
    // in employee class
    // name is shown outside 
    // so make it public
    public string name { get; set; }
    public string Address { get; set; }

    // validate function which also
    // shown outside

    // we only show valide outside 
    public void validate()
    {
        checkname();
        checkaddress();
    }

    // check name and address 
    // cannot accessable outside 

    // encapsulation implement abstraction
    private void checkname()
    {

    }
    private void checkaddress()
    {

    }
}