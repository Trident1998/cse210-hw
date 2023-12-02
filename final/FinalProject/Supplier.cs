class Supplier
{
    private String _country;
    private String _email;
    private String _phone;
    private String _name;


    public String DisplayInformation()
    {
        return $"Supplier name: {_name};\nSupplier country: {_country};\nSupplier email: {_email};\nSupplier phone: {_phone};";
    }

}