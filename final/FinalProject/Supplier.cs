class Supplier
{
    private String _country;
    private String _email;
    private String _phone;
    private String _name;

    public Supplier(String country, String email, String phone, String name)
    {
        _country = country;
        _email = email;
        _phone = phone;
        _name = name;
    }

    public Supplier()
    {
    }

    public String DisplayInformation()
    {
        return $"Supplier name: {_name};\nSupplier country: {_country};\nSupplier email: {_email};\nSupplier phone: {_phone};";
    }

    public static Supplier GetInstance()
    {
        String country = "";
        String email = "";
        String phone = "";
        String name = "";

        Console.Write("What is the Supplier country? ");
        country = Console.ReadLine();
        
        Console.Write("What is the Supplier email? ");
        email = Console.ReadLine();

        Console.Write("What is the Supplier phone? ");
        phone = Console.ReadLine();

        Console.Write("What is the Supplier name? ");
        name = Console.ReadLine();

        return new Supplier(country, email, phone, name);
    }

    public String GetStringRepresentation()
    {
        return $"{_country},{_email},{_phone},{_name}";
    }
}
