
class Program : Product
{
    public void main()
    {

        Product p = new Product();

        p.name = "test"; // public attribute can be access through an instanced object
        p.getPrice();//the only way to access the private attribute is with get and set methods
        brand = "test";// Inerited class Product allows to acces its protected attibutes directly
    }

}








