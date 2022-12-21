using System;
using static System.Console; 

class Sales  
{ 
    private string itemName;
    
    private double price;
    
    private int numItemSold;
    
    public Sales()
    {
        itemName = "";
        price = 0.0;
        numItemSold = 0;
    }
    
    public Sales(string name, double pr, int num)
    {
        itemName = name;
        price = pr;
        numItemSold = num;
    }
    
    public void getInput()
    {
        WriteLine("What would you like to order today? (Notebook, Pencils, Erasers, Bags, Paper)");
        itemName = ReadLine();
        
        WriteLine("Enter the " + itemName + " cost of each package: ");
        price = Convert.ToDouble(ReadLine()); 
        
        WriteLine(itemName + " cost $" + price.ToString("0.00") + " each package, how many packages would you like to order?");
        numItemSold = Convert.ToInt32(ReadLine());
        
        WriteLine("Thank you. Your order has been processed.");
    }
     
    public double salesAmount()
    {
        double SALES_TAX_RATE = 0.0865;
        
        double salesAmt = numItemSold * price + numItemSold * price * SALES_TAX_RATE;
        
        return salesAmt;
    }
    
    public void display()
    {
        double salesAmt = salesAmount();
        
        Console.WriteLine(itemName + " $" + price.ToString("0.00") + "        " + numItemSold + "        " + " $" + salesAmt.ToString("0.00"));
    }
}
  

class Program {
 
    static void Main() 
    {
        Sales s1 = new Sales();
        Sales s2 = new Sales();
        Sales s3 = new Sales();
         
        s1.getInput();
        s2.getInput();
        s3.getInput();
         
        WriteLine("\nItem: Price  ItemsSold  SalesAmount");
        s1.display();
        s2.display();
        s3.display();
    
      ReadKey();
    }
  }
