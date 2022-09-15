using System;

    class Customer
    {
    int Id;
    String Name;
    string Email;
    string City;

   
    public void InsertCustomer()
    {
        Console.WriteLine("Enter Customer Id: ");
        Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Customer Name: ");
        Name = Console.ReadLine();

        Console.WriteLine("Enter Customer Email: ");
        Email = Console.ReadLine();

        Console.WriteLine("Enter Customer City: ");
        City= Console.ReadLine();
    }

    public void CustomerDetails()
    {
        Console.WriteLine($"Customer Id: {Id}\nCustomer Name:{Name}\nEmail: {Email}\nCity: {City}");
    }

    public void UpdateCustomerDetails()
    {
        Console.WriteLine("Enter Id");
        int id1 = Convert.ToInt32(Console.ReadLine());

        if(Id.Equals(id1))
        {
            Console.WriteLine("Enter Customer Id: ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Customer Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Customer Email: ");
            Email = Console.ReadLine();

            Console.WriteLine("Enter Customer City: ");
            City = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Id does not exist");
        }
        Console.WriteLine("Upadeted Customer Details: ");
        Console.WriteLine($"Customer Id: {Id}\nCustomer Name:{Name}\nEmail: {Email}\nCity: {City}");
    }

    public void DeleteCustomerDetails()
    {
        Console.WriteLine("Enter Customer Id: ");
       int Id1 = Convert.ToInt32(Console.ReadLine());
        if(Id.Equals(Id1))
        {

        }
        
        Console.WriteLine("Deleted Customer Details: ");
        Console.WriteLine($"Customer Id: {Id}\nCustomer Name:{Name}\nEmail: {Email}\nCity: {City}");
    }

}

