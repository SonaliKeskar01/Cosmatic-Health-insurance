using System;
public class Student1
{
   public string Firstname ;
  public  string Lastname ;

    public Student1(string Firstname,string Lastname)
    {
        Firstname = Firstname;
        Lastname = Lastname;
    }

    public void printfullname()
    {
        Console.WriteLine($"FullName: {Firstname}  {Lastname}");
    }
}

  
