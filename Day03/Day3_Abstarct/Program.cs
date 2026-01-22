// See https://aka.ms/new-console-template for more information
using Day3_Abstarct;

Console.WriteLine("Hello, World!");
ElectronicProduct newobj1= new ElectronicProduct();
newobj1.ProductID = 101;
newobj1.ProductName = "smart TV";
newobj1.DisplayProductDetails();
newobj1.showProductDetails();

IDiscountTable discountTable1 = new ElectronicProduct();
double discount1 = discountTable1.CalculateDiscount(50000);
Console.WriteLine("discount", +discount1);

FurnitureProduct newObj2 = new FurnitureProduct();
newObj2.ProductID = 201;
newObj2.ProductName = "Sofa Set";
newObj2.DisplayProduct_Name_Details(); 
newObj2.ShowFurnitureProductDetails(); 

class ElectronicProduct : Product
{
    public override void DisplayProductDetails()
    {
        Console.WriteLine("Electronic Product Name:" + ProductName);
        Console.WriteLine("Electronic Product ID:" +ProductID);
    }
    public void showProductDetails()
    {
        Console.WriteLine("Product fromc child class");

    
    }

}