class Product
{
    /*
    public    -> Attributes and methods visibles for any classes
    private   -> Attributes and methods visibles only for the where is created
    protected -> Attributes and methods visibles for classes where are created and inherited classes
    */
    public string name;// accessible for any class
    private double price;// not accessible, the only way to attribute value is using get and set methods
    protected string brand;// accesible only if its class be inherited

    // Getter and Setter for private attribute price
    public double getPrice()
    {
        return this.price;
    }

    public void setPrice(double price)
    {
        this.price = price;
    }
}